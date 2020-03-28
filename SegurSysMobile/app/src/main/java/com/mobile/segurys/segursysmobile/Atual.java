package com.mobile.segurys.segursysmobile;

public class Atual {

    private String _id_atual;
    private String _trabalhando;
    private String _intervalo;
    private String _ponto_atual;
    private String _proximo_ponto;
    private String _id_func;

    public String get_id_atual() {
        return _id_atual;
    }

    public void set_id_atual(String _id_atual) {
        this._id_atual = _id_atual;
    }

    public String get_trabalhando() {
        return _trabalhando;
    }

    public void set_trabalhando(String _trabalhando) {
        this._trabalhando = _trabalhando;
    }

    public String get_intervalo() {
        return _intervalo;
    }

    public void set_intervalo(String _intervalo) {
        this._intervalo = _intervalo;
    }

    public String get_ponto_atual() {
        return _ponto_atual;
    }

    public void set_ponto_atual(String _ponto_atual) {
        this._ponto_atual = _ponto_atual;
    }

    public String get_proximo_ponto() {
        return _proximo_ponto;
    }

    public void set_proximo_ponto(String _proximo_ponto) {
        this._proximo_ponto = _proximo_ponto;
    }

    public String get_id_func() {
        return _id_func;
    }

    public void set_id_func(String _id_func) {
        this._id_func = _id_func;
    }

    public Atual(){

    }

    public Atual(String _id_atual, String _trabalhando, String _intervalo, String _ponto_atual, String _proximo_ponto, String _id_func){
        this._id_atual = _id_atual;
        this._trabalhando  = _trabalhando;
        this._intervalo = _intervalo;
        this._ponto_atual = _ponto_atual;
        this._proximo_ponto = _proximo_ponto;
        this._id_func = _id_func;
    }

}
