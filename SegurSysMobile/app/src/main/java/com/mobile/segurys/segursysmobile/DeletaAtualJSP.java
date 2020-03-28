package com.mobile.segurys.segursysmobile;

import android.app.Activity;
import android.app.ProgressDialog;
import android.os.AsyncTask;
import android.support.v7.app.AppCompatActivity;
import android.util.Log;
import android.view.Menu;

import java.io.InputStreamReader;
import java.net.HttpURLConnection;
import java.net.URL;
import java.util.List;

public class DeletaAtualJSP extends AsyncTask<Integer, Double, String> {
	private Activity ctx;
	private ProgressDialog progress;
	int totalReplicado = 0;

	public DeletaAtualJSP(AppCompatActivity ctx) {
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
            StringBuilder strURL = new StringBuilder();
            strURL.append("http://192.168.43.209:8080/ProjetoWeb/deletaAtual.jsp?id_func=");
            strURL.append(MenuActivity.idFunc);
            Log.d("enviaJSP... ", strURL.toString());

            try {
                URL url = new URL(strURL.toString());
                HttpURLConnection http = (HttpURLConnection) url.openConnection();
                InputStreamReader ips = new InputStreamReader(http.getInputStream());

            } catch (Exception ex) {
                Log.d("ExportarAgendaService", ex.getMessage());
            }
     return null;
    }


	//onPostExecute(Result)� Invocado depois que a thread principal finaliza e esta retorna algum valor como par�metro para este m�todo.
	protected void onPostExecute(String result) {
		progress.dismiss();
//		Toast.makeText(ctx, totalReplicado + " Registro(s) Enviado(s) com sucesso!", Toast.LENGTH_LONG).show();
	}
}