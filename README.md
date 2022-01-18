<!--
*** Plantilla de readme hecha por othneildrew
-->


<!-- PROJECT SHIELDS -->
![language-shield]
![release-shield]
[![Contributors][contributors-shield]][contributors-url] 
[![Issues][issues-shield]][issues-url]
[![Contact][discord-shield]][discord-url]




<!-- PROJECT LOGO -->
<br />
<p align="center">
  <h3 align="center">Proyecto PhotoPlay</h3>

  <p align="center">
    Juego de escritorio inspirado en los Photoplay de máquinas recreativas
    <br />
    ·
    <a href="https://github.com/Pikass0/Photoplay/issues">Report Bug</a>
    ·
    <a href="https://github.com/Pikass0/Photoplay/issues">Request Feature</a>
  </p>
</p>



<!-- TABLE OF CONTENTS -->
<details open="open">
  <summary>Contenido</summary>
  <ol>
    <li>
      <a href="#sobre-el-proyecto">Sobre el proyecto</a>
      <ul>
        <li><a href="#tecnologías">Tecnologías usadas</a></li>
      </ul>
    </li>
    <li>
      <a href="#probar-el-proyecto">Probar el proyecto</a>
      <ul>
        <li><a href="#requisitos">Requisitos</a></li>
        <li><a href="#instalación">Instalación</a></li>
      </ul>
    </li>
    <li><a href="#uso">Uso</a></li>
    <li><a href="#contribución">Contrubución</a></li>
  </ol>
</details>



<!-- ABOUT THE PROJECT -->
## Sobre el proyecto

![menu-ss]<!--(https://example.com) por si se quiere metir link-->

Juego basado en imágenes y preguntas. Proyecto para practicar Visual Basic con bases de datos MySQL.

¿Cómo jugar?
* Hay que responder el máximo de preguntas posibles
* Tienes 3 vidas y 1 comodin del 50%
* Cuanto antes respondas, más puntos conseguirás
* Investiga lo que ofrece la interfaz, hay pequeños ajustes de sonido, tops de score y poco más


### Tecnologías

Herramientas usadas:
* Xampp MySQL
* Visual Basic .NET



<!-- GETTING STARTED -->
## Probar el proyecto

Cómo ejecutar el proyecto:

### Requisitos

Descargar [Xampp](https://www.apachefriends.org/es/download.html) para la base de datos 


### Instalación

1. Abrir Xampp y dar a **Start** tanto en Apache como en MySQL, y cuando se haya iniciado, dar a **Admin** de MySQL

2. Crear una nueva base de datos llamada `photoplay3` e importar el archivo photoplay3.sql para crear y poblar las tablas

3. Ejecutar: `\PhotoPlay\bin\Debug\PhotoPlay.exe`

4. Supera en score a PikassoLegit, si puedes


<!-- USAGE EXAMPLES -->
## Uso

* Moviendo el cursor encima de los quesitos aparecerá un texto explicativo.
* Al hacer clic en jugar, pedirá un nickname, que posteriormente se utilizará para guardar tu score en la base de datos
* Responde la pregunta. Después, dale a la flecha de next para la siguiente pregunta
* Tienes comodín de 50% que te quitará dos respuestas incorrectas
* Puedes rendirte con el botón de la esquina inferior derecha
* Para salir, ve al menú y dale a salir. También puedes <kbd>Alt</kbd> + <kbd>F4</kbd> para salir en cualquier momento

![pregunta-ss]


<!-- CONTRIBUTING -->
## Contribución

Si quieres contribuir:

1. Fork el proyecto
2. Crea tu rama (`git checkout -b feature/AmazingFeature`)
3. Commit los cambios (`git commit -m 'Add some AmazingFeature'`)
4. Push a la rama (`git push origin feature/AmazingFeature`)
5. Abre un [Pull request](https://github.com/Pikass0/Photoplay/pulls)






<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->

[language-shield]: https://img.shields.io/badge/language-black?style=flat&logo=visual-studio
[discord-shield]: https://img.shields.io/badge/chat-on%20discord-7289da.svg?style=flat&logo=discord
[discord-url]: https://www.discord.com/users/290575161869205504
[release-shield]: https://img.shields.io/badge/release%20date-March%202018-lightgrey
[contributors-shield]: https://img.shields.io/github/contributors/Pikass0/Photoplay?color=green
[contributors-url]: https://github.com/Pikass0/Photoplay/graphs/contributors
[issues-shield]: https://img.shields.io/github/issues-raw/Pikass0/Photoplay?color=orange
[issues-url]: https://github.com/Pikass0/Photoplay/issues
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=flat&logo=linkedin&color=blue
[linkedin-url]: https://www.linkedin.com/in/marcelo-toral-martínez-573735176/
[menu-ss]: /PhotoPlay/Resources/fotosReadme/menu.jpg
[pregunta-ss]: /PhotoPlay/Resources/fotosReadme/pregunta.jpg
