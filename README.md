# [Roll a Ball] 
**Aluno:** [Eduardo Barbosa Fernandes] 
**Turma:** [2026.29.9] 
**Feito com:** Unity 6 e C# 
## Sobre o projeto 
   - [É um pequeno projeto onde o jogador controla uma pequena bola, e deve coletar todos os gatinhos e evitar os ursos para vencer, ]
## O que o projeto faz -
   - [O jogador pode se movimentar livremente usando as teclas WASD.] 
   - [Ao tocar nos gatinhos, eles somem, e o placar aumenta conforme o valor deles (gatinho normal - 1; super gatinho - 3).]
   - [Quando todas são coletadas, o jogador vai pro céu e aparece o texto de vitória.]
   - [Em caso do jogador encostar no urso (inimigo), ele some e aparece o texto de derrota.]
## O que o projeto contém - 
   **Cenas:** [MiniGame] 
   **Scripts:** 
   - [PlayerController.cs - É o código que movimenta o jogador e gerencia suas interações com outros objetos no projeto.]
   - [Colletable.cs - Faz a função dos coletáveis sumirem e adicionarem os pontos ao placar ao serem coletados]
   - [Rotate.cs - Faz os objetos rotacionarem no próprio eixo (como nos coletáveis).]
   - [GameManager.cs - Gerencia os textos de contador, vitória e derrota, bem como atualiza eles quando necessário.]
   - [CameraFollow.cs - Faz a câmera seguir o jogador a todo momento.]
   **Objetos principais:**
   - [Player, Ground(normal e heaven[vitória], Walls(normal e heaven[vitória], Obstacle, PickUp, Bear (inimigo),Canva, Direcional Light (1 e 2)] 
   **Recursos usados:**
   - [RigidBody, Collider nos objetos(Mesh Collider, Sphere Collider, Box Collider), Collider com Is Trigger, TextMeshPro] 
   ## Controles - 
   - [W] – [Anda para frente]
   - [S] – [Anda para trás]
   - [A] – [Anda para a esquerda]
   - [D] – [Anda para a direita]
   ## O que eu aprendi 
   - [Aprendi a como fazer movimentações básicas, bem como ficar familiarizado com a interface e mecânicas da Unity.] 
   ## Como abrir Baixe o projeto, abra o Unity Hub, clique em **Add** e escolha a pasta do projeto.
