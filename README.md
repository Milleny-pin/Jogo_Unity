# 🎮 Jogo de Plataforma 2D - Unity

## 📖 Sobre o projeto

Este projeto consiste no desenvolvimento de um jogo de plataforma 2D utilizando a engine **Unity** e a linguagem **C#**. O objetivo foi aplicar conceitos de programação, física 2D, design de níveis, animação e gerenciamento de cenas na construção de um jogo completo, com diferentes fases e mecânicas.

Ao longo do desenvolvimento foram implementados diversos sistemas, como inteligência artificial para inimigos, obstáculos dinâmicos, sistema de pontuação, coleta de moedas, transição entre fases e efeitos sonoros, proporcionando uma experiência de jogo divertida e desafiadora.

---

# 🎯 Objetivos

* Desenvolver um jogo de plataforma 2D funcional utilizando Unity.
* Aplicar conceitos de programação orientada a objetos em C#.
* Criar níveis com progressão de dificuldade.
* Implementar mecânicas variadas para aumentar a interatividade.
* Integrar animações, sprites, áudio e interface gráfica.

---

# 🕹️ Mecânicas do jogo

O jogador deve atravessar as fases superando obstáculos e inimigos até alcançar a bandeira que libera o próximo nível.

Entre as principais mecânicas estão:

* ✅ Movimentação lateral
* ✅ Sistema de pulo
* ✅ Som de pulo
* ✅ Coleta de moedas
* ✅ Sistema de pontuação
* ✅ Troca automática entre fases
* ✅ Inimigos com inteligência própria
* ✅ Obstáculos dinâmicos
* ✅ Plataformas destrutíveis
* ✅ Sistema de morte e reinício da fase

---

# 🌎 Fases

## 📄 Fase 1 — Mundo de Papel

A primeira fase possui uma estética inspirada em papel e funciona como introdução às mecânicas do jogo.

### Desafios

* Chuva de espadas
* Canhões que disparam projéteis automaticamente
* Plataformas
* Coleta de moedas
* Exploração do cenário

O jogador aprende os comandos básicos enquanto enfrenta obstáculos simples.

---

## 🏭 Fase 2 — Mundo Industrial

Na segunda fase o nível de dificuldade aumenta.

O cenário industrial apresenta novos inimigos e exige maior precisão nos movimentos.

### Inimigos

* 🦟 Mosquito voador
* 🐀 Rato patrulhando o cenário

Além disso, a disposição das plataformas torna a navegação mais complexa.

---

## ⚫⚪ Fase 3 — Mundo Preto e Branco

A terceira fase representa o desafio final do jogo.

Ela reúne praticamente todas as mecânicas apresentadas anteriormente, aumentando significativamente a dificuldade.

### Obstáculos

* ⚔️ Chuva de espadas
* 💣 Canhões
* 🦇 Inimigo voador perseguidor
* 👾 Inimigo terrestre inspirado no Goomba

Esta fase exige domínio completo das mecânicas de movimentação e tempo de reação.

---

# 👾 Inteligência Artificial dos inimigos

Cada inimigo possui comportamento próprio implementado através de scripts em C#.


### Mosquito

* Movimento contínuo
* Atua como obstáculo aéreo

### Rato

* Patrulha uma área específica
* Inverte direção automaticamente

### Inimigo voador

* Realiza movimentação horizontal e vertical
* Cria padrões imprevisíveis de ataque

---

# ⚔️ Obstáculos

O jogo conta com diversos obstáculos para aumentar o desafio:

* Chuva de espadas
* Canhões automáticos
* Projéteis
* Áreas de morte instantânea
* Plataformas temporárias

Todos foram implementados utilizando física 2D e detecção de colisão da Unity.

---

# 💰 Sistema de pontuação

Durante as fases o jogador pode coletar moedas.

Cada moeda:

* aumenta a pontuação;
* reproduz um efeito sonoro;
* desaparece após a coleta.

A pontuação é exibida na HUD durante toda a partida.

---

# 🎵 Áudio

O projeto utiliza efeitos sonoros para aumentar a imersão.

Atualmente estão implementados:

* 🔊 Som de pulo
* 🪙 Som de coleta de moedas

A estrutura permite adicionar facilmente músicas de fundo e efeitos específicos para inimigos e eventos.

---

# 🎨 Assets e animações

O jogo utiliza sprites 2D para personagens, inimigos e cenários.

Também foram criadas animações para:

* caminhada;
* voo;
* pulo;
* movimentação dos inimigos.

Cada fase possui identidade visual própria, tornando a experiência mais variada.

---

# 💻 Tecnologias utilizadas

* Unity
* C#
* Visual Studio
* Git
* GitHub

---

# 🧠 Conceitos aplicados

Durante o desenvolvimento foram aplicados conhecimentos de:

* Programação Orientada a Objetos
* Física 2D
* Game Loop
* Coroutines
* Inteligência Artificial básica
* Colisões e Triggers
* Gerenciamento de cenas
* Interface gráfica (HUD)
* Animações
* Design de níveis

---

# 📂 Estrutura do projeto

```text
Assets/
 ├── Animations
 ├── Audio
 ├── Prefabs
 ├── Scenes
 ├── Scripts
 ├── Sprites
 └── Tilemaps
```

---

# 🚀 Aprendizados

Este projeto proporcionou experiência prática no desenvolvimento de jogos digitais, permitindo integrar teoria e prática em um produto funcional.

Além do aprimoramento da programação em C#, o desenvolvimento contribuiu para o aprendizado sobre organização de projetos na Unity, criação de mecânicas de gameplay, design de níveis e utilização de ferramentas de versionamento com Git e GitHub.

---

# 👩‍💻 Desenvolvido por

**Milleny Souza**

Projeto acadêmico desenvolvido com foco no aprendizado de desenvolvimento de jogos 2D utilizando Unity e C#.
