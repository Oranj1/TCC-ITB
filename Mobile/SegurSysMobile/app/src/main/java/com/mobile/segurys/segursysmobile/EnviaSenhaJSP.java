package com.mobile.segurys.segursysmobile;

import android.app.Activity;
import android.app.ProgressDialog;
import android.os.AsyncTask;
import android.support.v7.app.AppCompatActivity;
import android.util.Log;

import java.io.InputStreamReader;
import java.net.HttpURLConnection;
import java.net.URL;
import java.util.List;

public class EnviaSenhaJSP extends AsyncTask<Integer, Double, String> {
	private Activity ctx;
	private ProgressDialog progress;
	int totalReplicado = 0;

	public EnviaSenhaJSP(AppCompatActivity ctx) {
		this.ctx = ctx;
	}

	//onPreExecute() � � executado antes do doInBackground().
	protected void onPreExecute() {
		Log.i("onPreExecute...  ", " ");
		progress = ProgressDialog.show(ctx, "Aguarde...", "Enviando dados para web!!!", true);
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
        List<Usuario> usuario = db.getAllUser();

        for (Usuario us : usuario) {
            //String log = "Id: "+cn.getID()+" ,Name: " + cn.getName() + " ,Phone: " + cn.getPhoneNumber();
            // Writing Contacts to log
            //String.valueOf(contador)
//        	Log.d("ID:    ", String.valueOf(cn.getID()));
//        	Log.d("Nome:  ", cn.getNome());
//        	Log.d("Email: ", cn.getEmail());
//        	Log.d("Fone:  ", cn.getFone());
//        	Log.d("Sexo:  ", cn.getSexo());

        	StringBuilder strURL = new StringBuilder();
			strURL.append("http://192.168.43.209:8080/ProjetoWeb/alteraSenha.jsp?senha=");
//			strURL.append("http://10.0.2.2:8080/ProjetoWeb/insereOcorrencia.jsp?nome=");
			strURL.append(us.get_senha());
			strURL.append("&id_func=");
			strURL.append(us.get_id_func());
			Log.d("enviaJSP... ", strURL.toString());
		 
			try{
				URL url = new URL(strURL.toString());
				HttpURLConnection http = (HttpURLConnection) url.openConnection();
				InputStreamReader ips = new InputStreamReader(http.getInputStream());
//				BufferedReader line = new BufferedReader(ips);
			 
//				String linhaRetorno = line.readLine();
//				totalReplicado++;
//				Log.d("Verificando Exportacao ", linhaRetorno);
//				if(linhaRetorno.equals("Y")){
//					Log.i("linhaRetorno.equals(Y)", " OK ");
//					db.deleteContact(cn.getID());
//					totalReplicado++;
//					Log.d("ExportarAgendaService..", linhaRetorno);
//				}
//				else
//				{
//					Log.i("linhaRetorno.equals(N)", " Fail ");
//				}
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