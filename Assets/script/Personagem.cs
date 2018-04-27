using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Personagem : MonoBehaviour {

    

    //public bool estaAtivo = false;

    public int queijos = 0;
    public Text pontosTexto;

   

    //componentes
    public Animator animatorPersonagem;
    public SpriteRenderer SpriteRendererPersonagem;
    //propriedades
    public float velocidade;
    public float forcaDoPulo;
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
        }

        if (movimentoVertical == 0)
        {
            animatorPersonagem.SetBool("pulando", false);
        }
        else
        {
            animatorPersonagem.SetBool("pulando", true);

        }


        //faz a animação
        if (movimentoHorizontal == 0)
        {
            //parado
            animatorPersonagem.SetBool("andando", false);
        }
        else
        {

            //amdando
            animatorPersonagem.SetBool("andando", true);
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
        }
    }

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
}
