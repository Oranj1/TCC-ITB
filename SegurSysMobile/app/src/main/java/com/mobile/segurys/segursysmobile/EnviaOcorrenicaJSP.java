package com.mobile.segurys.segursysmobile;

import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.net.HttpURLConnection;
import java.net.URL;
import java.util.List;
import android.app.Activity;
import android.app.ProgressDialog;
import android.os.AsyncTask;
import android.support.v7.app.AppCompatActivity;
import android.util.Log;
import android.widget.Toast;

public class EnviaOcorrenicaJSP extends AsyncTask<Integer, Double, String> {
	private Activity ctx;
	private ProgressDialog progress;
	int totalReplicado = 0;

	public EnviaOcorrenicaJSP(AppCompatActivity ctx) {
		this.ctx = ctx;
	}

	//onPreExecute() � � executado antes do doInBackground().
	protected void onPreExecute() {
		Log.i("onPreExecute...  ", " ");
		progress = ProgressDialog.show(ctx, "Aguarde...", "Enviando dados", true);
		Log.i("onPreExecute...  ", "..OK..");
	}

	// doInBackground(Params�)� A thread background. � chamado quando o onPreExecute finaliza.
	protected String doInBackground(Integer... params) {
		Log.i("doInBackground...  ", " Abrindo BD ");
        //Abrir/Criar o Banco de Dados
        //Declarando a classe de controle de conexao
        DatabaseHandler db = new DatabaseHandler(ctx);
        // Inserting Contacts
        Log.d("Reading: ", "Reading all contacts..");
        List<Ocorrencia> ocorrencia = db.getAllOco();
         
        for (Ocorrencia cn : ocorrencia) {
            //String log = "Id: "+cn.getID()+" ,Name: " + cn.getName() + " ,Phone: " + cn.getPhoneNumber();
            // Writing Contacts to log
            //String.valueOf(contador)
//        	Log.d("ID:    ", String.valueOf(cn.getID()));
//        	Log.d("Nome:  ", cn.getNome());
//        	Log.d("Email: ", cn.getEmail());
//        	Log.d("Fone:  ", cn.getFone());
//        	Log.d("Sexo:  ", cn.getSexo());

        	StringBuilder strURL = new StringBuilder();
			strURL.append("http://192.168.43.209:8080/ProjetoWeb/insereOcorrencia.jsp?acontecimento=");
//			strURL.append("http://10.0.2.2:8080/ProjetoWeb/insereOcorrencia.jsp?nome=");
			//strURL.append(cn.getNome());
			//Retirar Espacos do Nome
//			String nomeConv = cn.get_acontecimento();
//			while(nomeConv.indexOf(' ') != -1 )
//			{
//			    System.out.println("Acontecimento: " + nomeConv);
//			    nomeConv = nomeConv.substring(0, nomeConv.indexOf(' ')) + "%20" +
//			               nomeConv.substring(nomeConv.indexOf(' ') + 1);
//			}
//			System.out.println("Acontecimento: " + nomeConv);
			strURL.append(cn.get_acontecimento());
			strURL.append("&hora_data_registro=");
			strURL.append(cn.get_horario_data_registro());
			strURL.append("&_status=");
			strURL.append(cn.get_status());
			strURL.append("&nivel_ocorrencia=");
			strURL.append(cn.get_nivel_ocorrencia());
			strURL.append("&data_acontecimento=");
			strURL.append(cn.get_data_acontecimento());
			strURL.append("&hora_do_termino=");
			strURL.append(cn.get_hora_do_termino_oco());
			strURL.append("&hora_de_inicio=");
			strURL.append(cn.get_hora_de_inicio_oco());
			strURL.append("&id_area=");
			strURL.append(cn.get_id_area_oco());
			strURL.append("&id_func=");
			strURL.append(cn.get_id_func_oco());
			Log.d("enviaJSP... ", strURL.toString());
		 
			try{
				URL url = new URL(strURL.toString());
				HttpURLConnection http = (HttpURLConnection) url.openConnection();
				InputStreamReader ips = new InputStreamReader(http.getInputStream());

			} catch(Exception ex){
				Log.d("ExportarAgendaService", ex.getMessage());
			}
        }
		return null;
	}

	//onPostExecute(Result)� Invocado depois que a thread principal finaliza e esta retorna algum valor como par�metro para este m�todo.
//	protected void onPostExecute(String result) {
//		progress.dismiss();
////		Toast.makeText(ctx, totalReplicado + " Registro(s) Enviado(s) com sucesso!", Toast.LENGTH_LONG).show();
//	}
}