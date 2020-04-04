package com.mobile.segurys.segursysmobile;

import android.app.Activity;
import android.app.ProgressDialog;
import android.os.AsyncTask;
import android.util.Log;

import org.apache.http.HttpEntity;
import org.apache.http.HttpResponse;
import org.apache.http.client.ClientProtocolException;
import org.apache.http.client.HttpClient;
import org.apache.http.client.methods.HttpGet;
import org.apache.http.impl.client.DefaultHttpClient;

import java.io.IOException;
import java.util.Scanner;

/*class  OperacaoAlgumaCoisaWebServiceAsyncTask
           extends AsyncTask<Void, Void, Void> {
}
* Vendo a implementa��o desta classe percebemos que precisamos definir alguns tipos �Generic�. 
* Para o exemplo acima, colocamos todos como Void. Vamos entender para que serve cada tipo:
* Primeiro Generic(Params)  : o tipo que pode ser enviado para a thread  background desse mecanismo, ou seja, o m�todo doInBackground.
* Segundo  Generic(Progress): o tipo que pode ser usado para usar com finalidade de enviar o progresso de alguma execu��o da thread background.
* Terceiro Generic(Result)  : o tipo de retorno da thread background. */
public class RecebeAreaJSP extends AsyncTask<Integer, Double, String> {
	private Activity ctx;
	private ProgressDialog progress;

	public RecebeAreaJSP(Activity ctx) {
		this.ctx = ctx;
	}

	//onPreExecute() � � executado antes do doInBackground().
	protected void onPreExecute() {
		progress = ProgressDialog.show(ctx, "Aguarde...", "Baixando dados!!!", true);
	}

	// doInBackground(Params�)� A thread background. � chamado quando o onPreExecute finaliza.
	protected String doInBackground(Integer... params) {

		StringBuilder sb = new StringBuilder();
		try {
			HttpClient httpclient = new DefaultHttpClient();
			String endereco = "http://192.168.43.209:8080/ProjetoWeb/listarAreas.jsp";
//			String endereco = "http://10.0.2.2:8080/ProjetoWeb/listaContatosOra.jsp";
			Log.i("URL", endereco);

			HttpGet httpget = new HttpGet(endereco);
			HttpResponse response = httpclient.execute(httpget);
			HttpEntity entity = response.getEntity();
			if (entity != null) {
				Scanner s = new Scanner(entity.getContent());
				while (s.hasNext()) {
					sb.append(s.next());
				}
			}
			Log.i("Finalizou... ","Fim");
			
		} catch (ClientProtocolException e) {
			sb.append(e.getMessage());
		} catch (IllegalStateException e) {
			sb.append(e.getMessage());
		} catch (IOException e) {
			sb.append(e.getMessage());
		}	
		return sb.toString();
	}

	//onPostExecute(Result) Invocado depois que a thread principal finaliza e esta retorna algum valor como par�metro para este método.
	protected void onPostExecute(String result) {
		progress.dismiss();

        String[] matrizTela= new String[3];
        String LinhaDados = null;

	    //aqui ele pega a quantidade de carcteres que tem uma determinada vari�vel  
	    //e armazena numa INT para usa-la de contador
	    int contador = result.length();
	    String total =result.substring(result.indexOf("{")+1,result.indexOf("}"));
	    Log.i("Tot. Reg.:  ", total);
	    Log.i("Tot. Car.:  ", String.valueOf(contador));
	    int PosIni = 0;
	    int PosFin = 0;
	    String Pos1, Pos2, Pos3;
	        
	    //cria um for( para fazer uma varredura letra por letra at� encontrar
	    for(int i = 0;i<contador;i++)
	    {
	    	//usamos substring pra pegar um caractere, passando como par�metro,  
	    	//o primeiro caractere a ser pega, at� a ultima.  
	    	//fiz um if para verificar se o caractere � igual a "?"
	    	if (result.substring(i,i+1).equals("?")){ 
	    		{
	    			Log.i("i     :  ", String.valueOf(i));
	    			Log.i("PosIni:  ", String.valueOf(PosIni));
	    			Log.i("PosFin:  ", String.valueOf(PosFin=i));
	    			LinhaDados = result.substring(PosIni,PosFin).trim();
	    			LinhaDados = LinhaDados.replaceAll("[&]", " ");
	    			Log.i("String:  ", LinhaDados);
	    			PosIni = PosFin+1;
	    			/*Caso utilize a Classe Split.java que realiza a separa��o dos dados
		            * Split separados;
		            * separados = new Split();
		            * matrizTela = separados.separaDados(LinhaDados, "|"); */
	    			//Utilizando a metodo Split nativo do Java
	    			//Exemplo nomeString.split(limit);
	    			matrizTela = LinhaDados.split("[|]");
	    			//Retorna cada campo em uma posicao
		            Pos1 = matrizTela[0].toString();
		            Pos2 = matrizTela[1].toString();
		            Pos3 = matrizTela[2].toString();
					//Exibindo no console (Logcat)
		            Log.i("Pos1  :  ", Pos1);
		            Log.i("Pos2  :  ", Pos2);
		            Log.i("Pos3  :  ", Pos3);
		            //Declarando a classe de controle de conexao
                    DatabaseHandler db = new DatabaseHandler(ctx);
					// Inserting Contacts
			        Log.d("Insert: ", "Inserting ..");
					db.addAreas(Pos1, Pos2, Pos3);
	    		}    		
	    	}
	    } 
	}
}