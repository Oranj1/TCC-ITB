package com.mobile.segurys.segursysmobile;

import android.content.Context;
import android.content.Intent;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.MenuItem;
import android.widget.ListView;
import android.widget.SimpleCursorAdapter;


public class EscalaActivity extends AppCompatActivity {

    ListView ltvListarEscala;
    Context context = this;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_escala);
        getSupportActionBar().setDisplayHomeAsUpEnabled(true);
        getSupportActionBar().setHomeButtonEnabled(true);
        setTitle("Escala");
        ltvListarEscala = findViewById(R.id.ltvListarEscala);

        DatabaseHandler dbHand = new DatabaseHandler(this);

        String idFunc = MenuActivity.idFunc;
        String[] selectionArgs = new String[]{idFunc};

        SQLiteDatabase db = openOrCreateDatabase("segursys.db", context.MODE_PRIVATE, null);
        Cursor cursorSelect = db.rawQuery("select _id, dia_semana, horario_comeco, horario_termino from escala where id_func_esc = ? ", selectionArgs);

        String[] from = new String[]{"dia_semana" ,"horario_comeco", "horario_termino"};
        int[] to = new int[]{R.id.lblListarLayoutDia, R.id.lblListarLayoutComeco, R.id.lblListarLayoutFim};

        SimpleCursorAdapter adaptador = new SimpleCursorAdapter(getBaseContext(), R.layout.layout_listar, cursorSelect, from, to);
        ltvListarEscala.setAdapter(adaptador);
        db.close();
    }

    public boolean onOptionsItemSelected(MenuItem item) { //Botão adicional na ToolBar
        switch (item.getItemId()) {
            case android.R.id.home:
                startActivity(new Intent(this, MenuActivity.class));
                finish();
                break;
            default:break;
        }
        return true;
    }
}
