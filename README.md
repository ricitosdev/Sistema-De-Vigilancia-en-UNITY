# 🛡️ Sistema de Vigilancia en Unity 3D

Este proyecto implementa un sistema de vigilancia sencillo y funcional en Unity 3D. Permite colocar múltiples cámaras dentro de una escena y mostrar su señal en monitores o pantallas en tiempo real, simulando un sistema de CCTV.

## 📌 Características principales

🎥 Múltiples cámaras de vigilancia configurables dentro de la escena.

🖥️ RenderTexture para mostrar la vista de cada cámara en pantallas internas del juego.

🧩 Estructura modular, fácil de integrar en cualquier proyecto.

🚨 Preparado para ampliarse con detección de jugadores, alarmas u otros sistemas de seguridad.

🏗️ Código claro y organizado para aprender o usar como base en tus propios proyectos.

## 📁 Estructura del proyecto
/Assets

  -- Scripts
    <br>
    Player_Cntrl.cs          // Control básico de movimiento del jugador
    <br>
    SecutiryCamera_cntrl.cs  // Sistemta de control de vigilancia
    
  -- Scenes
  <br>
    SampleScene.unity           // Escena lista para probar

## 🚀 Cómo usarlo

Clona o descarga este repositorio.

Abre el proyecto con Unity (versión recomendada: 2021 o superior).

Abre la escena DemoScene.unity.

Observa los monitores dentro de la escena: cada uno muestra en tiempo real la cámara asignada.

Si quieres añadir una nueva cámara:

Duplica alguna de las cámaras existentes.

Asigna una nueva RenderTexture.

Enlaza esta textura al material de la pantalla correspondiente.

## 🧩 Personalización

Puedes ampliar este sistema fácilmente para:

Detectar al jugador con Raycast o OnTriggerEnter.

Activar alarmas cuando algo entre en el campo de visión.

Mover cámaras con rotación automática (estilo domo / PTZ).

Grabar o tomar capturas desde cámaras internas.

Si quieres, puedo ayudarte a implementar cualquiera de estas mejoras.

## 📜 Requisitos

Unity 2021.3 o superior (recomendado).

Conocimiento básico de:

GameObjects

Cameras

Materials & RenderTexture

## 🧑‍💻 Autor

Proyecto creado por RicitosDev.
Puedes usarlo libremente para aprendizaje o como base en tus propios proyectos.

📄 Licencia

Este repositorio se distribuye bajo la MIT License.
Puedes usarlo, modificarlo y distribuirlo sin restricciones, siempre dando crédito al autor.
