package com.mobile.segurys.segursysmobile;

public class Ocorrencia {

    private String _id_oco;
    private String _nivel_ocorrencia;
    private String _data_acontecimento;
    private String _acontecimento;
    private String _hora_do_termino_oco;
    private String _horario_data_registro;
    private String _hora_de_inicio_oco;
    private String _id_func_oco;
    private String _id_area_oco;
    private String _status;

    public String get_id_oco() {
        return _id_oco;
    }

    public void set_id_oco(String _id_oco) {
        this._id_oco = _id_oco;
    }

    public String get_nivel_ocorrencia() {
        return _nivel_ocorrencia;
    }

    public void set_nivel_ocorrencia(String _nivel_ocorrencia) {
        this._nivel_ocorrencia = _nivel_ocorrencia;
    }

    public String get_data_acontecimento() {
        return _data_acontecimento;
    }

    public void set_data_acontecimento(String _data_acontecimento) {
        this._data_acontecimento = _data_acontecimento;
    }

    public String get_acontecimento() {
        return _acontecimento;
    }

    public void set_acontecimento(String _acontecimento) {
        this._acontecimento = _acontecimento;
    }

    public String get_hora_do_termino_oco() {
        return _hora_do_termino_oco;
    }

    public void set_hora_do_termino_oco(String _hora_do_termino_oco) {
        this._hora_do_termino_oco = _hora_do_termino_oco;
    }

    public String get_horario_data_registro() {
        return _horario_data_registro;
    }

    public void set_horario_data_registro(String _horario_data_registro) {
        this._horario_data_registro = _horario_data_registro;
    }

    public String get_hora_de_inicio_oco() {
        return _hora_de_inicio_oco;
    }

    public void set_hora_de_inicio_oco(String _hora_de_inicio_oco) {
        this._hora_de_inicio_oco = _hora_de_inicio_oco;
    }

    public String get_id_func_oco() {
        return _id_func_oco;
    }

    public void set_id_func_oco(String _id_func_oco) {
        this._id_func_oco = _id_func_oco;
    }

    public String get_id_area_oco() {
        return _id_area_oco;
    }

    public void set_id_area_oco(String _id_area_oco) {
        this._id_area_oco = _id_area_oco;
    }

    public String get_status() {
        return _status;
    }

    public void set_status(String _status) {
        this._status = _status;
    }

     
    // Empty constructor
    public Ocorrencia(){
         
    }
    // constructor
    public Ocorrencia(String _id_oco, String _nivel_ocorrencia, String _data_acontecimento, String _acontecimento,
                      String _hora_do_termino_oco, String horario_data_registro, String _hora_de_inicio_oco, String _id_func_oco, String _id_area_oco, String _status){
        this._id_oco    = _id_oco;
        this._nivel_ocorrencia  = _nivel_ocorrencia;
        this._data_acontecimento = _data_acontecimento;
        this._acontecimento  = _acontecimento;
        this._hora_do_termino_oco  = _hora_do_termino_oco;
        this._horario_data_registro = horario_data_registro;
        this._hora_de_inicio_oco  = _hora_de_inicio_oco;
        this._id_func_oco  = _id_func_oco;
        this._id_area_oco  = _id_area_oco;
        this._status  = _status;
    }
}
