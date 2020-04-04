package com.mobile.segurys.segursysmobile;

import android.app.Activity;
import android.app.AlertDialog;
import android.content.ContentValues;
import android.content.Context;
import android.content.DialogInterface;
import android.content.Intent;
import android.content.SharedPreferences;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.hardware.Camera;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.KeyEvent;
import android.view.Menu;
import android.view.MenuInflater;
import android.view.MenuItem;
import android.view.View;
import android.widget.ImageView;
import android.widget.TextView;
import android.widget.Toast;

import com.google.zxing.integration.android.IntentIntegrator;
import com.google.zxing.integration.android.IntentResult;

import java.util.Calendar;
import java.util.Date;
import java.util.GregorianCalendar;


public class MenuActivity extends AppCompatActivity {

    public static String idFunc;


    Camera cam;
    //Itens QR Code
    ImageView imgQr;

    //Itens Opções
    ImageView imgConfig;

    //Itens Escala
    ImageView imgEscala;

    //Itens Ocorrência
    ImageView imgOco;

    //
    TextView lblNomePonto;

    Context context = this;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_menu);
        getSupportActionBar().setDisplayHomeAsUpEnabled(true);
        getSupportActionBar().setHomeButtonEnabled(true);
        setTitle("Menu");
        imgConfig = findViewById(R.id.imgConfig);
        imgQr = findViewById(R.id.imgQr);
        imgEscala = findViewById(R.id.imgEscala);
        imgOco = findViewById(R.id.imgOco);
        lblNomePonto = findViewById(R.id.lblNomePonto);

        SQLiteDatabase db = openOrCreateDatabase("segursys.db", context.MODE_PRIVATE, null);
        String[] selectionArgsAtual = new String[]{MenuActivity.idFunc};
        Cursor cursorAtual = db.rawQuery("select proximo_ponto from atual where id_func_atual = ? ", selectionArgsAtual);

        if(cursorAtual.moveToFirst()){
            lblNomePonto.setText(cursorAtual.getString(0));
        }else{
            lblNomePonto.setText("Entrada");
        }
        db.close();

        imgQr.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                abrirLeitor();
            }
        });
        imgConfig.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                abrirOpcoes();
            }
        });
        imgEscala.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                abrirEscala();
            }
        });
        imgOco.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                abrirOcorrencia();
            }
        });

    }
    public boolean onCreateOptionsMenu(Menu menu){
        MenuInflater inflater = getMenuInflater();
        inflater.inflate(R.menu.option_menu, menu);
        return super.onCreateOptionsMenu(menu);
    }

    public boolean onOptionsItemSelected(MenuItem item) { //Botão adicional na ToolBar
        switch (item.getItemId()) {
            case R.id.menuRecharge:
                DatabaseHandler dbHand = new DatabaseHandler(this);
                dbHand.resetFunc();
                dbHand.resetAreas();
                dbHand.resetEsc();
                dbHand.resetRonda();

                RecebeFuncJSP syncFunc = new RecebeFuncJSP(this);
                syncFunc.execute(0);
                RecebeAreaJSP syncArea = new RecebeAreaJSP(this);
                syncArea.execute(0);
                RecebeEscalaJSP syncEsc = new RecebeEscalaJSP(this);
                syncEsc.execute(0);
                RecebeRondaJSP syncRonda = new RecebeRondaJSP(this);
                syncRonda.execute(0);

                break;
            case android.R.id.home:
                alertar();
                break;
            default:
                break;
        }
        return true;
    }

    public void alertar() {
        DialogInterface.OnClickListener dialogClickListener = new DialogInterface.OnClickListener() {
            @Override
            public void onClick(DialogInterface dialog, int which) {
                switch (which) {
                    case DialogInterface.BUTTON_POSITIVE:
                        Intent actLogin = new Intent(getBaseContext(), LoginActivity.class);
                        finish();
                        startActivity(actLogin);
                        break;

                    case DialogInterface.BUTTON_NEGATIVE:
                        break;
                }
            }
        };
        AlertDialog.Builder builder = new AlertDialog.Builder(this);
        builder.setMessage("Tem certeza que deseja sair?").setPositiveButton("Sim", dialogClickListener)
                .setNegativeButton("Não", dialogClickListener).show();
    }
    public void onDestroy(){
        super.onDestroy();
        finish();
    }


    public void onStop() {
        super.onStop();
        SharedPreferences pref = getApplicationContext().getSharedPreferences("MyPref", MODE_PRIVATE);
        boolean marcado = pref.getBoolean("value", false);
        if (marcado) {
            if (cam != null) {
                cam.release();
                cam = null;
            }
        }
    }

    public void abrirOcorrencia() {
        Intent actOco = new Intent(MenuActivity.this, OcorrenciaActivity.class);
        startActivity(actOco);
    }

    public void abrirEscala() {
        Intent actEscala = new Intent(MenuActivity.this, EscalaActivity.class);
        startActivity(actEscala);
    }

    public void abrirOpcoes() {
        Intent actOpcoes = new Intent(MenuActivity.this, ListaConfigActivity.class);
        startActivity(actOpcoes);
    }

    public void abrirLeitor() {
        Activity activity = this;
        IntentIntegrator integrator = new IntentIntegrator(activity);
        integrator.setDesiredBarcodeFormats(IntentIntegrator.QR_CODE_TYPES);
        integrator.setPrompt("Escaneie o(a) " + retornarDica());
        integrator.setCameraId(0);
        integrator.setBeepEnabled(true);
        integrator.setOrientationLocked(false);
        integrator.initiateScan();
    }
    public String retornarDica(){
        String dica;
        SQLiteDatabase db = openOrCreateDatabase("segursys.db", context.MODE_PRIVATE, null);
        String[] selectionArgsAtual = new String[]{MenuActivity.idFunc};
        Cursor cursorAtual = db.rawQuery("select proximo_ponto from atual where id_func_atual = ? ", selectionArgsAtual);

        if(cursorAtual.moveToFirst()){
            dica = cursorAtual.getString(0);
        }else{
            dica = "Entrada";
        }
        db.close();
        return dica;
    }

    public boolean onKeyDown(int keyCode, KeyEvent event) {
        SharedPreferences pref = getApplicationContext().getSharedPreferences("MyPref", MODE_PRIVATE);
        boolean marcado = pref.getBoolean("value", false);
        if (marcado) {

            switch (keyCode) {
                case KeyEvent.KEYCODE_VOLUME_UP:
                    cam = Camera.open();
                    if (cam != null) {
                        Camera.Parameters p = cam.getParameters();
                        p.setFlashMode(Camera.Parameters.FLASH_MODE_TORCH);
                        cam.setParameters(p);
                        cam.startPreview();
                        break;
                    }

                case KeyEvent.KEYCODE_VOLUME_DOWN:
                    cam = Camera.open();
                    if (cam != null) {
                        Camera.Parameters pOff = cam.getParameters();
                        pOff.setFlashMode(Camera.Parameters.FLASH_MODE_OFF);
                        cam.setParameters(pOff);
                        cam.startPreview();
                        cam.release();
                        cam = null;
                        break;
                    }
            }
        }
        return true;
    }
    public String getDiaSemana() {
        String diaSemana = "";
        Date d = new Date();
        Calendar c = new GregorianCalendar();
        c.setTime(d);
        int dia = c.get(c.DAY_OF_WEEK);
        switch (dia) {
            case Calendar.SUNDAY:
                diaSemana = "Domingo";
                break;
            case Calendar.MONDAY:
                diaSemana = "Segunda";
                break;
            case Calendar.TUESDAY:
                diaSemana = "Terça";
                break;
            case Calendar.WEDNESDAY:
                diaSemana = "Quarta";
                break;
            case Calendar.THURSDAY:
                diaSemana = "Quinta";
                break;
            case Calendar.FRIDAY:
                diaSemana = "Sexta";
                break;
            case Calendar.SATURDAY:
                diaSemana = "Sábado";
                break;
        }
        return diaSemana;
    }

    @Override
    protected void onActivityResult(int requestCode, int resultCode, Intent data) {
        IntentResult result = IntentIntegrator.parseActivityResult(requestCode, resultCode, data);
        if (result != null) {
            if (result.getContents() != null) {
                SQLiteDatabase db = openOrCreateDatabase("segursys.db", context.MODE_PRIVATE, null);
                if (result.getContents().toString().equals("Entrada")) {
                    String[] selectionArgsAtual = new String[]{MenuActivity.idFunc};
                    Cursor cursorAtual = db.rawQuery("select _id_atual from atual where id_func_atual = ? ", selectionArgsAtual);
                    if(!cursorAtual.moveToFirst()){
                        String diaSemana = getDiaSemana();
                        String[] selectionArgsFunc = new String[]{diaSemana, idFunc};
                        Cursor cursorFunc = db.rawQuery("select _id from escala where dia_semana = ? and id_func_esc = ? ", selectionArgsFunc);
                        if (cursorFunc.moveToFirst()) {
                            String idEscala = cursorFunc.getString(0);
                            String[] selectionArgsEsc = new String[]{idEscala};
                            Cursor cursorEsc = db.rawQuery("select rota from ronda where id_esc_ronda = ? ", selectionArgsEsc);
                            if (cursorEsc.moveToFirst()) {
                                String caminho = cursorEsc.getString(0);
                                String[] pontosDoCaminho = caminho.split("_");

                                ContentValues cvt = new ContentValues();
                                cvt.put("id_func_atual", idFunc);
                                cvt.put("trabalhando", "Sim");
                                cvt.put("intervalo", "Não");
                                cvt.put("ponto_atual", "Entrada");
                                cvt.put("proximo_ponto", pontosDoCaminho[0]);
                                db.insert("atual", null, cvt);
                                lblNomePonto.setText(pontosDoCaminho[0]);
                                mensagem("ponto escaneado com sucesso");

                                EnviaAtualJSP syncAtual =  new EnviaAtualJSP(MenuActivity.this);
                                syncAtual.execute(0);
                            }
                            else{
                                mensagem("você não tem rota para " + diaSemana);
                            }
                        }else{
                            mensagem("Você não tem escala para " + diaSemana);
                        }
                    }else{
                        mensagem("Você já escaneou a entrada hoje");
                    }
                } else if (result.getContents().toString().equals("Saida")) {
                    String[] selectionArgsAtual = new String[]{MenuActivity.idFunc};
                    Cursor cursorAtual = db.rawQuery("select _id_atual from atual where id_func_atual = ? ", selectionArgsAtual);
                    if (cursorAtual.moveToFirst()) {
                        String delete = "delete from atual where id_func_atual = '" + MenuActivity.idFunc + "'";
                        db.execSQL(delete);
                        mensagem("Você escaneou a saida");
                        lblNomePonto.setText("Entrada");
                        DeletaAtualJSP syncAtual =  new DeletaAtualJSP(MenuActivity.this);
                        syncAtual.execute(0);
                    }
                    else{
                        mensagem("Você não está trabalhando");
                    }
                } else if (result.getContents().toString().equals("Intervalo")) {
                    String[] selectionArgsAtual = new String[]{MenuActivity.idFunc};
                    Cursor cursorAtual = db.rawQuery("select _id_atual from atual where id_func_atual = ? ", selectionArgsAtual);
                    if (cursorAtual.moveToFirst()) {
                        ContentValues cvt = new ContentValues();
                        cvt.put("intervalo", "Sim");
                        db.update("atual", cvt, "id_func_atual = ?", new String[]{MenuActivity.idFunc});
                        mensagem("Em intervalo");
                        AlteraAtualJSP syncAtual =  new AlteraAtualJSP(MenuActivity.this);
                        syncAtual.execute(0);
                    }else{
                        mensagem("Você não está trabalhando");
                    }

                } else if (result.getContents().toString().equals("Volta do Intervalo")) {
                    String[] selectionArgsAtual = new String[]{MenuActivity.idFunc, "Sim"};
                    Cursor cursorAtual = db.rawQuery("select _id_atual from atual where id_func_atual = ? and intervalo = ?", selectionArgsAtual);
                    if (cursorAtual.moveToFirst()) {
                        ContentValues cvt = new ContentValues();
                        cvt.put("intervalo", "Não");
                        db.update("atual", cvt, "id_func_atual = ?", new String[]{MenuActivity.idFunc});
                        mensagem("Volta do intervalo");
                        AlteraAtualJSP syncAtual =  new AlteraAtualJSP(MenuActivity.this);
                        syncAtual.execute(0);
                    }else{
                        mensagem("Você não está trabalhando ou não está em intervalo");
                    }
                } else {
                    String idPonto = result.getContents().toString();
                    String[] selectionArgsArea = new String[]{idPonto};
                    Cursor cursorArea = db.rawQuery("select ponto from area where _id_area = ? ", selectionArgsArea);

                    if (cursorArea.moveToFirst()) {
                        String ponto = cursorArea.getString(0); //é um ponto existente

                        String idFunc = MenuActivity.idFunc;

                        String diaSemana = getDiaSemana();
                        String[] selectionArgsFunc = new String[]{diaSemana, idFunc};
                        Cursor cursorFunc = db.rawQuery("select _id from escala where dia_semana = ? and id_func_esc = ? ", selectionArgsFunc);
                        if (cursorFunc.moveToFirst()) {
                            String idEscala = cursorFunc.getString(0);
                            String[] selectionArgsEsc = new String[]{idEscala};
                            Cursor cursorEsc = db.rawQuery("select rota from ronda where id_esc_ronda = ? ", selectionArgsEsc);
                            if (cursorEsc.moveToFirst()) {
                                String caminho = cursorEsc.getString(0);
                                String[] pontosDoCaminho = caminho.split("_");
                                String[] selectionArgsAtual = new String[]{MenuActivity.idFunc, "Não"};
                                int tamArray = pontosDoCaminho.length -1;
                                String proximoPonto;
                                Cursor cursorAtual = db.rawQuery("select ponto_atual, proximo_ponto,_id_atual from atual where id_func_atual = ? and intervalo == ?", selectionArgsAtual);
                                if (cursorAtual.moveToFirst()) {
                                    proximoPonto = cursorAtual.getString(1);
                                    int i = 0;
                                    if (proximoPonto.equals(ponto)) {
                                        mensagem("ponto escaneado com sucesso");
                                        while (!proximoPonto.equals(pontosDoCaminho[i])) {
                                            i++;
                                        }
                                        if(i == tamArray){
                                            lblNomePonto.setText(pontosDoCaminho[0]);
                                            ContentValues cvt = new ContentValues();
                                            cvt.put("ponto_atual", pontosDoCaminho[i]);
                                            cvt.put("proximo_ponto", pontosDoCaminho[0]);
                                            db.update("atual", cvt, "id_func_atual = ?", new String[]{MenuActivity.idFunc});
                                            AlteraAtualJSP syncAtual =  new AlteraAtualJSP(MenuActivity.this);
                                            syncAtual.execute(0);
                                        }else {
                                            i++;
                                            lblNomePonto.setText(pontosDoCaminho[i]);
                                            ContentValues cvt = new ContentValues();
                                            cvt.put("ponto_atual", pontosDoCaminho[i - 1]);
                                            cvt.put("proximo_ponto", pontosDoCaminho[i]);
                                            db.update("atual", cvt, "id_func_atual = ?", new String[]{MenuActivity.idFunc});
                                            AlteraAtualJSP syncAtual =  new AlteraAtualJSP(MenuActivity.this);
                                            syncAtual.execute(0);
                                        }
                                    } else {
                                        mensagem("Esse não é seu proximo ponto");
                                    }
                                }else{
                                    mensagem("É Necessário escanear a entrada primeiro, ou você está em intervalo");
                                }
                            }else{
                                mensagem("Você não tem ronda para esse dia");
                            }
                        }else{
                            mensagem("VocÊ não tem escala para " + diaSemana);
                        }
                    }
                    else{
                        mensagem("Isso não é um ponto");
                    }
                }
                db.close();
            } else {
                mensagem("A Leitura Falhou");
            }

        } else {
            super.onActivityResult(requestCode, resultCode, data);
        }

    }
    public void onBackPressed(){
        super.onBackPressed();
        alertar();
    }

    private void mensagem(String msg) {
        Toast.makeText(getApplicationContext(), "" + msg, Toast.LENGTH_LONG).show();
    }
}