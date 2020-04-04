package com.mobile.segurys.segursysmobile;

import android.content.ContentValues;
import android.content.Context;
import android.content.DialogInterface;
import android.content.Intent;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.support.v7.app.AlertDialog;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.text.InputType;
import android.view.MenuItem;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

public class MudarSenhaActivity extends AppCompatActivity {
    Button btnConfirmar;
    EditText txtSenha;
    EditText txtConfirmarSenha;
    Context context = this;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_config);
        getSupportActionBar().setDisplayHomeAsUpEnabled(true);
        getSupportActionBar().setHomeButtonEnabled(true);
        setTitle("Alterar Senha");
        txtSenha = findViewById(R.id.txtSenha);
        txtConfirmarSenha = findViewById(R.id.txtConfirmarSenha);
        btnConfirmar = findViewById(R.id.btnConfirmar);
        setTheme(R.style.Principal);

        btnConfirmar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                if (txtSenha.getText().toString().equals(txtConfirmarSenha.getText().toString()) && !(txtSenha.getText().toString().equals(""))) {
                    if (txtSenha.getText().toString().length() >= 6 && txtSenha.getText().toString().length() <= 16) {
                        AlertDialog.Builder janelaSenha = new AlertDialog.Builder(MudarSenhaActivity.this);
                        final EditText input = new EditText(MudarSenhaActivity.this);
                        janelaSenha.setTitle("Digite sua Senha atual:");
                        input.setInputType(InputType.TYPE_TEXT_VARIATION_PASSWORD);
                        janelaSenha.setView(input);

                        janelaSenha.setPositiveButton("Confirmar", new DialogInterface.OnClickListener() {
                            @Override
                            public void onClick(DialogInterface dialog, int which) {
                                SQLiteDatabase db = openOrCreateDatabase("segursys.db", context.MODE_PRIVATE, null);
                                String[] selectionArgs = new String[]{MenuActivity.idFunc, input.getText().toString()};
                                Cursor cursor =  db.rawQuery("select _id_func from funcionario where _id_func = ? and senha = ? ",selectionArgs);
                                if(cursor.moveToFirst()) {
                                    ContentValues cvt = new ContentValues();
                                    cvt.put("senha",txtSenha.getText().toString());
                                    EnviaSenhaJSP sendPass = new EnviaSenhaJSP(MudarSenhaActivity.this);
                                    sendPass.execute(0);
                                    txtSenha.setText("");
                                    txtConfirmarSenha.setText("");

                                    if(db.update("funcionario",cvt,"_id_func = ?", new String[]{MenuActivity.idFunc}) > 0) {
                                        mensagem("Senha alterada com sucesso");
                                        finish();
                                    }else{
                                        mensagem("Algo deu errado");
                                    }
                                    db.close();
                                }else{
                                    mensagem("A senha não corresponde a atual");
                                }
                            }
                        });

                        janelaSenha.setNegativeButton("Cancelar", new DialogInterface.OnClickListener() {
                            @Override
                            public void onClick(DialogInterface dialog, int which) {
                                dialog.cancel();
                                mensagem("Operação Cancelada");
                            }
                        });
                        janelaSenha.show();
                    } else {
                        mensagem("A senha deve conter entre 6 e 16 caractéres");
                        txtConfirmarSenha.setError("A senha deve conter entre 6 e 16 caractéres");
                        txtSenha.setError("A senha deve conter entre 6 e 16 caractéres");
                    }
                } else {
                    mensagem("As senhas não são iguais, ou estão vazias");
                    txtConfirmarSenha.setError("As senhas não são iguais, ou estão vazias");
                    txtSenha.setError("As senhas não são iguais, ou estão vazias");
                }

            }
        });
    }
    public boolean onOptionsItemSelected(MenuItem item) { //Botão adicional na ToolBar
        switch (item.getItemId()) {
            case android.R.id.home:
                finish();
                break;
            default:break;
        }
        return true;
    }
    public void mensagem(String msg){
        Toast.makeText(getBaseContext(), msg, Toast.LENGTH_LONG).show();
    }
}
