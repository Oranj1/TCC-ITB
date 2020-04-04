package com.mobile.segurys.segursysmobile;

import java.util.ArrayList;
import java.util.List;

import android.annotation.SuppressLint;
import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;
import android.view.Menu;

@SuppressLint("DefaultLocale")
@SuppressWarnings("unused")
public class DatabaseHandler extends SQLiteOpenHelper {

    // All Static variables
    // Database Version
    private static final int DATABASE_VERSION = 2;
    // Database Name
    private static final String DATABASE_NAME = "segursys.db";
    //TABLE FUNCIONARIO;
    private static final String TABLE_FUNCIONARIO = "funcionario";
    private static final String KEY_ID_FUNC = "_id_func";
    private static final String KEY_NOME_FUNC = "nome";
    private static final String KEY_USUARIO_FUNC = "usuario";
    private static final String KEY_SENHA_FUNC = "senha";
    private static final String KEY_ATIVO_FUNC = "ativo_func";
    //TABLE ESCALA
    private static final String TABLE_ESC = "Escala";
    private static final String KEY_ID_ESC = "_id";
    private static final String KEY_COMECO_ESC = "horario_comeco";
    private static final String KEY_FIM_ESC = "horario_termino";
    private static final String KEY_FUNC_ESC = "id_func_esc";
    private static final String KEY_ATIVO_ESC = "ativo_esc";
    private static final String KEY_DIA_ESC = "dia_semana";
    //TABLE AREA
    private static final String TABLE_AREA = "Area";
    private static final String KEY_ID_AREA = "_id_area";
    private static final String KEY_PONTO = "ponto";
    private static final String KEY_ATIVO_AREA = "ativo_area";
    //TABLE OCO
    private static final String TABLE_OCO = "Ocorrencia";
    private static final String KEY_ID_OCO = "_id_oco";
    private static final String KEY_NIVEL_OCO = "nivel_ocorrencia";
    private static final String KEY_DATA_OCO = "data_acontecimento";
    private static final String KEY_ACON_OCO = "acontecimento";
    private static final String KEY_HORA_FIM_OCO = "hora_do_termino_oco";
    private static final String KEY_HORA_INI_OCO = "hora_do_inicio_oco";
    private static final String KEY_DATA_REG_OCO = "horario_data_registro";
    private static final String KEY_ID_FUNC_OCO = "id_func_oco";
    private static final String KEY_ID_AREA_OCO = "id_area_oco";
    private static final String KEY_STATUS_OCO = "_status";
    //TABLE RONDA
    private static final String TABLE_RONDA = "Ronda";
    private static final String KEY_ID_RONDA = "_id_ronda";
    private static final String KEY_ROTA_RONDA = "rota";
    private static final String KEY_ID_ESC_RONDA = "id_esc_ronda";
    private static final String KEY_ATIVO_RONDA = "ativo_ronda";
    private static final String KEY_TEMPO_RONDA = "tempo";
    //TABLE ATUAL
    private static final String TABLE_ATUAL = "Atual";
    private static final String KEY_ID_ATUAL = "_id_atual";
    private static final String KEY_TRABALHANDO_ATUAL = "trabalhando";
    private static final String KEY_INTERVALO_ATUAL = "intervalo";
    private static final String KEY_PROXIMO_ATUAL = "proximo_ponto";
    private static final String KEY_PONTO_ATUAL = "ponto_atual";
    private static final String KEY_ID_FUNC_ATUAL = "id_func_atual";

    public DatabaseHandler(Context context) {
        super(context, DATABASE_NAME, null, DATABASE_VERSION);
    }

    // Creating Tables
    @Override
    public void onCreate(SQLiteDatabase db) {

        String funcTable;
        funcTable = "CREATE TABLE IF NOT EXISTS funcionario (";
        funcTable += "_id_func INTEGER PRIMARY KEY, ";
        funcTable += "nome VARCHAR(150), ";
        funcTable += "usuario VARCHAR(50), ";
        funcTable += "senha VARCHAR(16), ";
        funcTable += "ativo_func CHAR(1))";
        db.execSQL(funcTable);

        String escTable;
        escTable = "CREATE TABLE IF NOT EXISTS escala (";
        escTable += "_id INTEGER PRIMARY KEY, ";
        escTable += "horario_comeco TIME, ";
        escTable += "horario_termino TIME, ";
        escTable += "dia_semana VARCHAR(10), ";
        escTable += "id_func_esc INTEGER, ";
        escTable += "ativo_esc CHAR(1))";
        db.execSQL(escTable);

        String ocoTable;
        ocoTable = "CREATE TABLE IF NOT EXISTS ocorrencia (";
        ocoTable += "_id_oco INTEGER PRIMARY KEY AUTOINCREMENT, ";
        ocoTable += "nivel_ocorrencia VARCHAR(150), ";
        ocoTable += "data_acontecimento DATE, ";
        ocoTable += "acontecimento VARCHAR(500), ";
        ocoTable += "hora_do_termino_oco TIME, ";
        ocoTable += "horario_data_registro DATETIME, ";
        ocoTable += "hora_de_inicio_oco TIME, ";
        ocoTable += "id_func_oco INTEGER, ";
        ocoTable += "id_area_oco INTEGER, ";
        ocoTable += "_status VARCHAR(26))";
        db.execSQL(ocoTable);

        String areaTable;
        areaTable = "CREATE TABLE IF NOT EXISTS area (";
        areaTable += "_id_area INTEGER  PRIMARY KEY, ";
        areaTable += "ponto VARCHAR(50),";
        areaTable += "ativo_area CHAR(1))";
        db.execSQL(areaTable);

        String rondaTable;
        rondaTable = "CREATE TABLE IF NOT EXISTS ronda (";
        rondaTable += "_id_ronda INTEGER  PRIMARY KEY, ";
        rondaTable += "rota VARCHAR(100), ";
        rondaTable += "id_esc_ronda INTEGER, ";
        rondaTable += "ativo_ronda CHAR(1), ";
        rondaTable += "tempo TIME)";
        db.execSQL(rondaTable);

        String atualTable;
        atualTable = "CREATE TABLE IF NOT EXISTS atual (";
        atualTable += "_id_atual INTEGER PRIMARY KEY AUTOINCREMENT, ";
        atualTable += "trabalhando CHAR(3), ";
        atualTable += "intervalo CHAR(3), ";
        atualTable += "ponto_atual VARCHAR(30), ";
        atualTable += "proximo_ponto VARCHAR(30), ";
        atualTable += "id_func_atual INTEGER)";
        db.execSQL(atualTable);
    }

    // Upgrading database
    @Override
    public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {
        String drop;
        drop = "DROP TABLE IF EXISTS [funcionario] ";
        db.execSQL(drop);
        drop = "DROP TABLE IF EXISTS [escala] ";
        db.execSQL(drop);
        drop = "DROP TABLE IF EXISTS [ocorrencia] ";
        db.execSQL(drop);
        drop = "DROP TABLE IF EXISTS [area] ";
        db.execSQL(drop);
        drop = "DROP TABLE IF EXISTS [ronda] ";
        db.execSQL(drop);
    }

    /**
     * All CRUD(Create, Read, Update, Delete) Operations
     */

    @SuppressLint("DefaultLocale")
    // Adding new contact
    void addFuncionarios(String id, String nome, String usuario, String senha, String ativo) {
        SQLiteDatabase db = this.getWritableDatabase();
        ContentValues values = new ContentValues();
        values.put(KEY_ID_FUNC, id);
        values.put(KEY_NOME_FUNC, nome);
        values.put(KEY_USUARIO_FUNC, usuario);
        values.put(KEY_SENHA_FUNC, senha);
        values.put(KEY_ATIVO_FUNC, ativo);
        // Inserting Row
        db.insert(TABLE_FUNCIONARIO, null, values);
        db.close(); // Closing database connecting
    }

    public void resetFunc() {
        SQLiteDatabase db = this.getWritableDatabase();
        db.execSQL("delete from funcionario");
    }

    void addAreas(String id, String ponto, String ativo) {
        SQLiteDatabase db = this.getWritableDatabase();
        ContentValues values = new ContentValues();
        values.put(KEY_ID_AREA, id);
        values.put(KEY_PONTO, ponto);
        values.put(KEY_ATIVO_AREA, ativo);
        // Inserting Row
        db.insert(TABLE_AREA, null, values);
        db.close(); // Closing database connecting
    }

    public void resetAreas() {
        SQLiteDatabase db = this.getWritableDatabase();
        db.execSQL("delete from Area");
    }

    void addEscala(String id, String inicio, String fim, String dia, String idFunc, String ativo) {
        SQLiteDatabase db = this.getWritableDatabase();
        ContentValues values = new ContentValues();
        values.put(KEY_ID_ESC, id);
        values.put(KEY_COMECO_ESC, inicio);
        values.put(KEY_FIM_ESC, fim);
        values.put(KEY_DIA_ESC, dia);
        values.put(KEY_FUNC_ESC, idFunc);
        values.put(KEY_ATIVO_ESC, ativo);
        // Inserting Row
        db.insert(TABLE_ESC, null, values);
        db.close(); // Closing database connecting
    }

    public void resetEsc() {
        SQLiteDatabase db = this.getWritableDatabase();
        db.execSQL("delete from Escala");
    }

    void addRonda(String id, String rota, String idEscala,String ativo ,String tempo) {
        SQLiteDatabase db = this.getWritableDatabase();
        ContentValues values = new ContentValues();
        values.put(KEY_ID_RONDA, id);
        values.put(KEY_ROTA_RONDA, rota);
        values.put(KEY_ID_ESC_RONDA, idEscala);
        values.put(KEY_TEMPO_RONDA, tempo);
        values.put(KEY_ATIVO_RONDA, ativo);
        // Inserting Row
        db.insert(TABLE_RONDA, null, values);
        db.close(); // Closing database connecting
    }

    public void resetRonda() {
        SQLiteDatabase db = this.getWritableDatabase();
        db.execSQL("delete from Ronda");
    }


    //
//
//    // Updating single contact
//    public int updateContact(int id, String nome, String email, String fone, String sexo) {
//        SQLiteDatabase db = this.getWritableDatabase();
//
//        ContentValues values = new ContentValues();
//        values.put(KEY_NOME, nome.toUpperCase());
//        values.put(KEY_EMAIL, email.toLowerCase());
//        values.put(KEY_FONE, fone);
//        values.put(KEY_SEXO, sexo.toUpperCase());
//
//        // updating row
//        return db.update(TABLE_AGENDA, values, KEY_ID + " = ?",
//                new String[]{String.valueOf(id)});
//    }
//
//    // Deleting single contact
//    public void deleteContact(int id) {
//        SQLiteDatabase db = this.getWritableDatabase();
//        db.delete(TABLE_AGENDA, KEY_ID + " = ?",
//                new String[]{String.valueOf(id)});
//        db.close();
//    }
//
//    // Deleting all contact
//    public void deleteAllContact() {
//        SQLiteDatabase db = this.getReadableDatabase();
//        db.execSQL("DELETE FROM " + TABLE_AGENDA);
//        db.close();
//    }
//
//
//    // Getting contacts Count
//    public int getContactsCount() {
//
//        String countQuery = "SELECT * FROM " + TABLE_AGENDA;
//        SQLiteDatabase db = this.getReadableDatabase();
//        Cursor cursor = db.rawQuery(countQuery, null);
//        int count = 0;
//        try {
//            if (cursor.moveToFirst()) {
//                count = cursor.getCount();
//            }
//            return count;
//        } finally {
//            if (cursor != null) {
//                cursor.close();
//            }
//        }
//    }
//
//
    // Getting All Contacts
    public List<Ocorrencia> getAllOco() {

        List<Ocorrencia> ocoList = new ArrayList<Ocorrencia>();
        // Select All Query
        String selectQuery = "SELECT * FROM " + TABLE_OCO;

        SQLiteDatabase db = this.getWritableDatabase();
        Cursor cursor = db.rawQuery(selectQuery, null);

        // looping through all rows and adding to list
        if (cursor.moveToLast()) {
            Ocorrencia ocorrencia = new Ocorrencia();
            ocorrencia.set_id_oco(cursor.getString(0));
            ocorrencia.set_nivel_ocorrencia(cursor.getString(1));
            ocorrencia.set_data_acontecimento(cursor.getString(2));
            ocorrencia.set_acontecimento(cursor.getString(3));
            ocorrencia.set_hora_do_termino_oco(cursor.getString(4));
            ocorrencia.set_horario_data_registro(cursor.getString(5));
            ocorrencia.set_hora_de_inicio_oco(cursor.getString(6));
            ocorrencia.set_id_func_oco(cursor.getString(7));
            ocorrencia.set_id_area_oco(cursor.getString(8));
            ocorrencia.set_status(cursor.getString(9));
            // Adding contact to list
            ocoList.add(ocorrencia);

        }

        // return contact list
        return ocoList;
    }
    public List<Usuario> getAllUser(){
        List<Usuario> userList = new ArrayList<Usuario>();
        // Select All Query
        String selectQuery = "SELECT senha, _id_func FROM " + TABLE_FUNCIONARIO + " WHERE _id_func = '" + MenuActivity.idFunc + "'";

        SQLiteDatabase db = this.getWritableDatabase();
        Cursor cursor = db.rawQuery(selectQuery, null);

        // looping through all rows and adding to list
        if (cursor.moveToLast()) {
            Usuario usuario = new Usuario();
            usuario.set_senha(cursor.getString(0));
            usuario.set_id_func(cursor.getString(1));
            // Adding contact to list
            userList.add(usuario);
        }
        // return contact list
        return userList;
    }
    public List<Atual> getAllAtual(){
        List<Atual> atualList = new ArrayList<Atual>();
        // Select All Query
        String selectQuery = "SELECT _id_atual, trabalhando, intervalo, ponto_atual, proximo_ponto, id_func_atual FROM " + TABLE_ATUAL + " WHERE id_func_atual = '" + MenuActivity.idFunc + "'";
        SQLiteDatabase db = this.getWritableDatabase();
        Cursor cursor = db.rawQuery(selectQuery, null);
        // looping through all rows and adding to list
        if (cursor.moveToLast()) {
            Atual atual = new Atual();
            atual.set_id_atual(cursor.getString(0));
            atual.set_trabalhando(cursor.getString(1));
            atual.set_intervalo(cursor.getString(2));
            atual.set_ponto_atual(cursor.getString(3));
            atual.set_proximo_ponto(cursor.getString(4));
            atual.set_id_func(cursor.getString(5));
            atualList.add(atual);
        }
        // return contact list
        return atualList;
    }
}
