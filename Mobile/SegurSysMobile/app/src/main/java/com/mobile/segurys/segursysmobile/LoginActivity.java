package com.mobile.segurys.segursysmobile;

import android.content.Context;
import android.content.Intent;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.text.method.PasswordTransformationMethod;
import android.view.View;
import android.widget.Button;
import android.widget.CheckBox;
import android.widget.CompoundButton;
import android.widget.TextView;
import android.widget.Toast;

public class LoginActivity extends AppCompatActivity {
    CheckBox ckShow;
    TextView txtSenha;
    TextView txtUsuario;
    Button btnEntrar;

    Context context = this;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_login);
        setTitle("Login");
        ckShow = findViewById(R.id.ckShow);
        txtSenha = findViewById(R.id.txtSenha);
        btnEntrar = findViewById(R.id.btnEntrar);
        txtUsuario =  findViewById(R.id.txtUsuario);

        CarregarDados();

        ckShow.setOnCheckedChangeListener(new CompoundButton.OnCheckedChangeListener() {
            @Override
            public void onCheckedChanged(CompoundButton buttonView, boolean isChecked) {
                if(!(isChecked)){
                    txtSenha.setTransformationMethod(new PasswordTransformationMethod());
                }else{
                    txtSenha.setTransformationMethod(null);
                }
            }
        });

        btnEntrar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                SQLiteDatabase db = openOrCreateDatabase("segursys.db", context.MODE_PRIVATE, null);
                String user = txtUsuario.getText().toString();
                String pass = txtSenha.getText().toString();
                String[] selectionArgs = new String[]{user, pass};
                Cursor cursor =  db.rawQuery("select _id_func from funcionario where usuario = ? and senha = ? ",selectionArgs);

                if(cursor.moveToFirst()) {
                    MenuActivity.idFunc = cursor.getString(0);
                    Intent actMenu = new Intent(LoginActivity.this, MenuActivity.class);
                    startActivity(actMenu);
                    finish();
                }
                else{
                    txtUsuario.setError("Usuario ou senha inválidos");
                    txtSenha.setError("Usuario ou senha inválidos");
                    mensagem("Usuário ou senha inválidos");
                }
                db.close();
            }
        });
    }
    public void mensagem(String msg){
        Toast.makeText(getBaseContext(), msg, Toast.LENGTH_LONG).show();
    }
    public void CarregarDados(){
        try {
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
        }
        catch (Exception ex){
            throw ex;
        }
    }
    public void onBackPressed(){
        super.onBackPressed();
        finish();
    }
}