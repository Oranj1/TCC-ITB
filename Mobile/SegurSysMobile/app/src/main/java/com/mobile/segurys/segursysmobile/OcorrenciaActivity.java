package com.mobile.segurys.segursysmobile;

import android.app.DatePickerDialog;
import android.app.Dialog;
import android.app.TimePickerDialog;
import android.content.ContentValues;
import android.content.Context;
import android.content.DialogInterface;
import android.content.Intent;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.MenuItem;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.DatePicker;
import android.widget.EditText;
import android.widget.Spinner;
import android.widget.TimePicker;
import android.widget.Toast;

import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Calendar;
import java.util.Date;

public class OcorrenciaActivity extends AppCompatActivity {
    int mHour, mMinute;
    Context context = this;

    EditText txtHoraInicio;
    EditText txtData;
    EditText txtHoraFim;
    Spinner spnAcontecimentos;
    EditText txtOco;
    Spinner spnNiveis;
    Spinner spnStatus;
    Spinner spnArea;
    Button btnContinuar;
    DatePickerDialog.OnDateSetListener date;
    TimePickerDialog.OnTimeSetListener time;

    Calendar myCalendar = Calendar.getInstance();
    String dataEHoraInsert;


    @Override
    protected void onCreate(Bundle savedInstanceState) {

        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_ocorrencia);
        getSupportActionBar().setDisplayHomeAsUpEnabled(true);
        getSupportActionBar().setHomeButtonEnabled(true);
        setTitle("Registrar Ocorrência");
        setTheme(R.style.Principal);

        txtHoraInicio = findViewById(R.id.txtHoraInicio);
        txtHoraFim = findViewById(R.id.txtHoraFim);
        txtData = findViewById(R.id.txtData);
        txtOco = findViewById(R.id.txtOco);
        spnNiveis = findViewById(R.id.spnNiveis);
        spnStatus  =findViewById(R.id.spnStatus);
        spnAcontecimentos = findViewById(R.id.spnAcontecimentos);
        btnContinuar = findViewById(R.id.btnRegistrarOcorrencia);
        spnArea = findViewById(R.id.spnArea);

        SimpleDateFormat dateFormatData = new SimpleDateFormat("dd-MM-yyyy");
        Date data = new Date();
        Calendar cal = Calendar.getInstance();
        cal.setTime(data);
        Date dataAutal = cal.getTime();
        String dataCompleta = dateFormatData.format(data);
        txtData.setText(dataCompleta.toString().replace('-','/'));
        SimpleDateFormat dateFormatHora = new SimpleDateFormat("HH:mm");
        String horaCompleta = dateFormatHora.format(dataAutal);
        txtHoraInicio.setText(horaCompleta);


        SQLiteDatabase db = openOrCreateDatabase("segursys.db", context.MODE_PRIVATE, null);
        Cursor cursorArea = db.rawQuery("select ponto from Area", null);
        final ArrayList<String> mArrayList = new ArrayList<String>();
        for(cursorArea.moveToFirst(); !cursorArea.isAfterLast(); cursorArea.moveToNext()) {
            mArrayList.add(cursorArea.getString(0));
        }
        if(cursorArea.moveToFirst()) {
            ArrayAdapter<String> dataAdapter = new ArrayAdapter<String>(this,
                    android.R.layout.simple_spinner_item, mArrayList );
            dataAdapter.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
            spnArea.setAdapter(dataAdapter);
        }

        int posRonda = 0;
        String pontoAtual;
        String[] selectionArgsAtual = new String[]{MenuActivity.idFunc};
        Cursor cursorAtual = db.rawQuery("select ponto_atual from atual where id_func_atual = ? ", selectionArgsAtual);
        if(cursorAtual.moveToFirst()) {
            pontoAtual = cursorAtual.getString(0);
            if(!pontoAtual.equals("Entrada")) {
                while (!mArrayList.get(posRonda).equals(pontoAtual)) {
                    posRonda++;
                }
                spnArea.setSelection(posRonda);
            }else{
                spnArea.setSelection(0);
            }
        }else{
            spnArea.setSelection(0);
        }
        db.close();

        date = new DatePickerDialog.OnDateSetListener() {

            @Override
            public void onDateSet(DatePicker view, int year, int monthOfYear, int dayOfMonth) {
                myCalendar.set(Calendar.YEAR, year);
                myCalendar.set(Calendar.MONTH, monthOfYear);
                myCalendar.set(Calendar.DAY_OF_MONTH, dayOfMonth);
                String myFormat = "dd/MM/yyyy"; //In which you need put here
                SimpleDateFormat sdf = new SimpleDateFormat(myFormat);
                txtData.setText(sdf.format(myCalendar.getTime()));
                txtData.setError(null);
            }
        };


        txtData.setOnClickListener(new View.OnClickListener() {
            public void onClick(View v) {
                new DatePickerDialog(OcorrenciaActivity.this, date, myCalendar
                        .get(Calendar.YEAR), myCalendar.get(Calendar.MONTH),
                        myCalendar.get(Calendar.DAY_OF_MONTH)).show();
            }
        });

        txtHoraInicio.setOnClickListener(new View.OnClickListener() {
            public void onClick(View v) {
                final Calendar c = Calendar.getInstance();
                mHour = c.get(Calendar.HOUR_OF_DAY);
                mMinute = c.get(Calendar.MINUTE);

                // Launch Time Picker Dialog
                TimePickerDialog timePickerDialog = new TimePickerDialog(OcorrenciaActivity.this,
                        new TimePickerDialog.OnTimeSetListener() {

                            @Override
                            public void onTimeSet(TimePicker view, int hourOfDay,
                                                  int minute) {
                                String hour = hourOfDay + "";
                                String min = minute + "";

                                if (hour.length() == 1) {
                                    hour = "0" + hour;
                                }
                                if (min.length() == 1) {
                                    min = "0" + min;
                                }

                                txtHoraInicio.setText(hour + ":" + min);
                            }
                        }, mHour, mMinute, false);
                timePickerDialog.setOnCancelListener(new DialogInterface.OnCancelListener() {
                    @Override
                    public void onCancel(DialogInterface dialog) {
                        txtHoraInicio.setText("");
                    }
                });
                timePickerDialog.show();
            }
        });

        txtHoraFim.setOnClickListener(new View.OnClickListener() {
            public void onClick(View v) {
                final Calendar c = Calendar.getInstance();
                mHour = c.get(Calendar.HOUR_OF_DAY);
                mMinute = c.get(Calendar.MINUTE);

                // Launch Time Picker Dialog
                TimePickerDialog timePickerDialog = new TimePickerDialog(OcorrenciaActivity.this,
                        new TimePickerDialog.OnTimeSetListener() {

                            @Override
                            public void onTimeSet(TimePicker view, int hourOfDay,
                                                  int minute) {
                                String hour = hourOfDay + "";
                                String min = minute + "";

                                if (hour.length() == 1) {
                                    hour = "0" + hour;
                                }
                                if (min.length() == 1) {
                                    min = "0" + min;
                                }

                                txtHoraFim.setText(hour + ":" + min);
                            }
                        }, mHour, mMinute, false);
                timePickerDialog.setOnCancelListener(new DialogInterface.OnCancelListener() {
                    @Override
                    public void onCancel(DialogInterface dialog) {
                        txtHoraFim.setText("");
                    }
                });
                timePickerDialog.show();
            }
        });
        spnAcontecimentos.setOnItemSelectedListener(new AdapterView.OnItemSelectedListener() {
            @Override
            public void onItemSelected(AdapterView<?> parent, View view, int position, long id) {
                if (position == 2) {
                    txtOco.setVisibility(View.VISIBLE);
                } else {
                    txtOco.setVisibility(View.INVISIBLE);
                }
            }

            @Override
            public void onNothingSelected(AdapterView<?> parent) {
                return;
            }
        });

        btnContinuar.setOnClickListener(new View.OnClickListener() {

            String acontecimento;
            String status;
            String nivel;
            String area;
            @Override
            public void onClick(View v) {
                int i = 0;
                int posicao = spnAcontecimentos.getSelectedItemPosition();
                if(!txtHoraInicio.getText().toString().equals("")) {
                    if (posicao == 2) {
                        if (!txtOco.getText().toString().equals("")) {
                            acontecimento = txtOco.getText().toString();
                            i = 0;
                        } else {
                            txtOco.setError("Campo vazio");
                            mensagem("Campo de acontecimento vazio");
                            i = 1;
                        }
                    } else {
                        if (posicao == 0) {
                            acontecimento = "Roubo";
                        } else {
                            acontecimento = "Invasão";
                        }
                    }
                    if (i == 0) {

                        int posicaoStatus = spnStatus.getSelectedItemPosition();


                        if (posicaoStatus == 0) {
                            status = "Solucionado";
                        } else if (posicaoStatus == 1) {
                            status = "Em Aberto";
                        } else {
                            status = "Encaminhado para a Policia";
                        }

                        int posicaoArea = spnArea.getSelectedItemPosition();
                        area = mArrayList.get(posicaoArea);
                        SQLiteDatabase db = openOrCreateDatabase("segursys.db", context.MODE_PRIVATE, null);
                        String[] selectionArgsArea = new String[]{area};
                        Cursor cursorArea = db.rawQuery("select _id_area from Area where ponto = ?", selectionArgsArea);
                        if (cursorArea.moveToFirst()) {
                            area = cursorArea.getString(0);
                        }

                        int posicaoNivel = spnNiveis.getSelectedItemPosition();

                        if (posicaoNivel == 0) {
                            nivel = "Baixo";
                        } else if (posicaoNivel == 1) {
                            nivel = "Médio";
                        } else {
                            nivel = "Alto";
                        }

                        SimpleDateFormat dateFormatData = new SimpleDateFormat("dd-MM-yyyy");
                        Date data = new Date();
                        Calendar cal = Calendar.getInstance();
                        cal.setTime(data);
                        Date dataAutal = cal.getTime();
                        String dataCompleta = dateFormatData.format(data);
                        dataEHoraInsert = dataCompleta.toString().replace('-', '/');
                        SimpleDateFormat dateFormatHora = new SimpleDateFormat("HH:mm");
                        String horaCompleta = dateFormatHora.format(dataAutal);
                        dataEHoraInsert += " " + horaCompleta;

                        try {
                            if (validarData(txtData.getText().toString()) == false) {
                                txtData.setError("Data Inválida");
                                mensagem("Data Inválida");
                            } else {
                                try {

                                    SQLiteDatabase dbo = openOrCreateDatabase("segursys.db", context.MODE_PRIVATE, null);
                                    EnviaOcorrenicaJSP sendOco = new EnviaOcorrenicaJSP(OcorrenciaActivity.this);
                                    sendOco.execute(0);
                                    ContentValues cvt = new ContentValues();
                                    cvt.put("_status", status);//obter status;
                                    cvt.put("nivel_ocorrencia", nivel);//obter nivel;
                                    cvt.put("hora_de_inicio_oco", txtHoraInicio.getText().toString());
                                    if (txtHoraFim.getText().toString().length() != 0) {
                                        cvt.put("hora_do_termino_oco", txtHoraFim.getText().toString());
                                    }
                                    cvt.put("data_acontecimento", txtData.getText().toString());
                                    cvt.put("acontecimento", acontecimento);
                                    cvt.put("horario_data_registro", dataEHoraInsert);
                                    cvt.put("id_func_oco", MenuActivity.idFunc);
                                    cvt.put("id_area_oco", area);//Obter data;

                                    if (dbo.insert("ocorrencia", "_id_oco", cvt) > 0) {
                                        mensagem("Ocorrência registrada");
                                        finish();
                                    } else {
                                        mensagem("Algo deu errado, tente novamente");
                                    }
                                    dbo.close();
                                } catch (Exception ex) {
                                    ex.getMessage();
                                }
                            }
                        } catch (ParseException e) {
                            e.printStackTrace();
                        }
                    }
                }else{
                    txtHoraInicio.setError("Campo vazio");
                    mensagem("Campo de hora vazio");
                }
            }

        });

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

    public boolean validarData(String data) throws ParseException {
        if(data.length() == 0) {
            return false;
        }else{
            //pega data atual
            Date dataAtual = new Date();
            Calendar cal = Calendar.getInstance();
            cal.setTime(dataAtual);
            //

            //converte data
            SimpleDateFormat format = new SimpleDateFormat("dd/MM/yyyy");
            Date convertedDate;
            convertedDate = format.parse(data);
            //
            if(convertedDate.after(dataAtual)){
                return false;
            }
            else{
                return true;
            }
        }
    }
    public void mensagem(String msg){
        Toast.makeText(getApplicationContext(), msg, Toast.LENGTH_LONG).show();
    }
}