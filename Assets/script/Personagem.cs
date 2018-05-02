using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Personagem : MonoBehaviour {

    

    //public bool estaAtivo = false;

    public int queijos = 0;
    public Text pontosTexto;
    public float tempo;
    public bool tempoGo;
    public int vidas = 3;
    public GameObject pesao;
   

    //componentes
    public Animator animatorPersonagem;
    public SpriteRenderer SpriteRendererPersonagem;
    //propriedades
    public float velocidade;
    public float forcaDoPulo = 0;
    public bool estaPulando = false;

    //input do jogador
    public float movimentoHorizontal;
    public float movimentoVertical;
    //posição do personagem
    public float posicaoHorizontalAtual;
    public float posicaoVerticalAtual;
    //
    public void Awake()
    {
        animatorPersonagem = GetComponent<Animator>();
        SpriteRendererPersonagem = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        movimentoHorizontal = Input.GetAxis("Horizontal") * Time.deltaTime;
        movimentoVertical = Input.GetAxis("Vertical") * Time.deltaTime;
    }
    public void FixedUpdate()
    {
        if (!estaPulando && movimentoVertical > 0)
            {
            estaPulando = true;
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * forcaDoPulo);
            pesao.SetActive(false);
        }

      /*  if (movimentoVertical == 0)
        {
            animatorPersonagem.SetBool("pulando", false);
            
        }
        else
        {

<<<<<<< HEAD
            animatorPersonagem.SetBool("pulando", true);
            
        }
=======
        }*/
>>>>>>> cb685e0e2bb0615e876f7abd91a26e736e3dbb5f


        //faz a animação
        if (movimentoHorizontal == 0)
        {
            //parado
            animatorPersonagem.SetBool("andando", false);
        }
        else
        {
            if (!estaPulando)
            {
                animatorPersonagem.SetBool("andando", true);
            }
            //amdando
            
            if (movimentoHorizontal > 0)
            {
                //direita
                SpriteRendererPersonagem.flipX = false;
            }
            else
            {
                //esquerda
                SpriteRendererPersonagem.flipX = true;
            }
        }

        //
        posicaoHorizontalAtual = transform.position.x + (movimentoHorizontal * velocidade);
        transform.position = new Vector2(posicaoHorizontalAtual, transform.position.y);
       // posicaoVerticalAtual = transform.position.y + (movimentoVertical * forcaDoPulo);

    }
    public void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "chao")
        {
            estaPulando = false;
<<<<<<< HEAD
            forcaDoPulo = 400;
            pesao.SetActive(true);
=======
            animatorPersonagem.SetBool("pulando", false);
>>>>>>> cb685e0e2bb0615e876f7abd91a26e736e3dbb5f
        }

    }


    //GetComponent<Rigidbody2D>().AddForce(Vector2.up * forcaDoPulo);

    public void AddQueijo()
    {
        queijos++;
        pontosTexto.text = queijos.ToString();
    }

    public void OnCollisionEnter2D(Collision2D checaqueijo)
    {
        if (checaqueijo.gameObject.CompareTag("queijominas"))
        {
            AddQueijo();
            Debug.Log("Quejos: " + queijos);
        }
    }

   public void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "chao")
        {
            estaPulando = true;
            animatorPersonagem.SetBool("pulando", true);
            animatorPersonagem.SetBool("andando", false);
        }
    }
}
