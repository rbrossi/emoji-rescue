using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gerenciador {

	private bool liberadoBotao1 = true;
	private bool liberadoBotao2 = true;
	private bool disparar = false;
	private bool carregado = false;
	private bool zerou = false;
	private bool mostrandoPerdeu = false;
	private int faseparavoltar = 0;
	private float timer = 0;
	private static Gerenciador uniqueGerenciador;
	private int vidas = 5;
	private Vector3 posicaoBola = new Vector3(0, 0.0f, 0f);
	public int cena = 0;

	private Gerenciador(){
		
	}

	public static Gerenciador getInstance(){
		if (uniqueGerenciador == null) {
			uniqueGerenciador = new Gerenciador ();
		}
		return uniqueGerenciador;
	}

	public void setPosicaoBola(Vector3 v){
		this.posicaoBola = v;
	}

	public Vector3 getPosicaoBola(){
		return posicaoBola;
	}

	public bool isLiberadoBotao1(){
		return liberadoBotao1;
	}

	public void setLiberadoBotao1(bool status){
		this.liberadoBotao1 = status;
	}

	public int getCena(){
		return cena;
	}

	public void setCena(int cena){
		this.cena = cena;
	}

	public bool isLiberadoBotao2(){
		return liberadoBotao2;
	}

	public void setLiberadoBotao2(bool status){
		this.liberadoBotao2 = status;
	}

	public bool isCarregado(){
		return carregado;
	}

	public void setCarregado(bool status){
		this.carregado = status;
	}

	public bool isZerou(){
		return zerou;
	}

	public void setZerou(bool status){
		this.zerou = status;
	}

	public bool isDisparar(){
		return disparar;
	}

	public void setDisparar(bool status){
		this.disparar = status;
	}

	public int getVidas(){
		return this.vidas;
	}

	public void setVidas(int vidas){
		this.vidas = vidas;
	}

	public void chamarPerdeu(int fase){
		mostrandoPerdeu = true;
		faseparavoltar = fase;
		SceneManager.LoadScene (5);
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
