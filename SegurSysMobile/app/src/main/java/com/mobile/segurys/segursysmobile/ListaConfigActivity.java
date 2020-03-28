package com.mobile.segurys.segursysmobile;

import android.content.Intent;
import android.content.SharedPreferences;
import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.view.MenuItem;
import android.view.View;
import android.widget.CompoundButton;
import android.widget.Switch;
import android.widget.TextView;

public class ListaConfigActivity extends AppCompatActivity {
    Switch swFlash;
    TextView lblTrocarSenha;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_lista_config);
        getSupportActionBar().setDisplayHomeAsUpEnabled(true);
        getSupportActionBar().setHomeButtonEnabled(true);
        setTitle("Opções");

        swFlash = findViewById(R.id.swFlash);
        lblTrocarSenha = findViewById(R.id.lblTrocarSenha);

        SharedPreferences pref = getApplicationContext().getSharedPreferences("MyPref", MODE_PRIVATE);
        boolean marcado = pref.getBoolean("value", false);  // getting boolean
        //Toast.makeText(getApplicationContext(), marcado + "", Toast.LENGTH_LONG).show();
        swFlash.setChecked(marcado);


        swFlash.setOnCheckedChangeListener(new CompoundButton.OnCheckedChangeListener() {
            @Override
            public void onCheckedChanged(CompoundButton buttonView, boolean isChecked) {
                if(isChecked) {
                    //Toast.makeText(getBaseContext(), "marcado", Toast.LENGTH_SHORT).show();
                    SharedPreferences pref = getApplicationContext().getSharedPreferences("MyPref", MODE_PRIVATE);
                    SharedPreferences.Editor editor = pref.edit();
                    editor.putBoolean("value", true);           // Saving boolean - true/false
                    editor.commit(); // commit changes
                }else{
                    //Toast.makeText(getBaseContext(), "desmarcado", Toast.LENGTH_SHORT).show();
                    SharedPreferences pref = getApplicationContext().getSharedPreferences("MyPref", MODE_PRIVATE);
                    SharedPreferences.Editor editor = pref.edit();
                    editor.putBoolean("value", false);
                    editor.commit(); // commit changes
                }
            }
        });

        lblTrocarSenha.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent actOpcoes = new Intent(ListaConfigActivity.this,MudarSenhaActivity.class);
                startActivity(actOpcoes);
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
}
