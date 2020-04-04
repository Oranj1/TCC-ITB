package com.mobile.segurys.segursysmobile;

public class Usuario {
    private String _usuario;
    private String _senha;
    private String _id_func;

    public String get_usuario() {
        return _usuario;
    }

    public void set_usuario(String _usuario) {
        this._usuario = _usuario;
    }

    public String get_senha() {
        return _senha;
    }

    public void set_senha(String _senha) {
        this._senha = _senha;
    }

    public String get_id_func() {
        return _id_func;
    }

    public void set_id_func(String _id_func) {
        this._id_func = _id_func;
    }

    public Usuario(){

    }

    public Usuario(String _usuario,String _senha, String id_func){
        this._id_func = _id_func;
        this._senha  = _senha;
        this._usuario = _usuario;
    }
}
