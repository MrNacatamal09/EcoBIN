# EcoBIN

Descripción general del proyecto
EcoBIN es una aplicación de escritorio desarrollada en C# con Windows Forms, cuyo objetivo es incentivar y gestionar actividades de reciclaje mediante un sistema de puntos. Cada usuario registrado puede ingresar materiales reciclados, acumular puntos, consultar su historial, visualizar un ranking general y canjear beneficios predefinidos. El sistema también permite la gestión de usuarios mediante un rol administrador, el cual tiene acceso exclusivo a ciertas funciones como actualización, eliminación de usuarios y generación de reportes.

Objetivo del sistema
El propósito principal de EcoBIN es fomentar hábitos responsables con el medio ambiente mediante una plataforma sencilla donde los usuarios puedan registrar sus acciones ecológicas y ver reflejado su esfuerzo mediante puntos y recompensas.

Público objetivo
El sistema está dirigido al entorno de la Universidad Americana UAM, con el fin de mantener un control básico y automatizado de las actividades ecológicas realizadas.

Arquitectura y almacenamiento
EcoBIN utiliza archivos de texto (.txt) y Comma-Separated Values (.csv) para almacenar información.
Se emplean tres archivos principales dentro de una carpeta asignada:


• usuarios.txt contiene CIF, nombre, contraseña, puntos y rol.


• registros.csv contiene cada registro de reciclaje por usuario.


• canjes.csv almacena los canjes realizados con fecha y tipo de beneficio.



El sistema se basa en clases, servicios y ventanas organizadas de la siguiente manera:


• Modelos define las estructuras de datos como Usuario, RegistroReciclaje, CanjeBeneficio.


• Servicios contiene clases responsables de leer, escribir y actualizar información en los archivos.


• Ventanas_Adicionales contiene los formularios que componen la interfaz gráfica.

Roles del sistema


• Usuario común puede registrarse automáticamente desde el login, registrar materiales, consultar puntos, visualizar ranking y realizar canjes.


• Usuario administrador no genera registros ni puntos. Su función es gestionar usuarios, acceder a reportes y supervisar el funcionamiento general del sistema.



Características principales:


• Registro automático de usuarios mediante CIF, nombre y contraseña.


• Inicio de sesión validado por credenciales.


• Registro de materiales reciclados asociado a puntos.


• Consulta detallada de historial de reciclaje y movimientos.


• Canje de puntos basado en beneficios predefinidos.


• Ranking global basado en los puntos acumulados.


• Administración de usuarios (actualización y eliminación).


• Generación de reportes para análisis global.


• Sistema de advertencias y bloqueos según rol.



Requerimientos mínimos


• Windows 10 o superior


• Microsoft .NET Framework 4.7.2 o superior


• Visual Studio para desarrolladores



Producción y derechos
EcoBIN es un proyecto académico creado con fines educativos para la gestión de actividades relacionadas al reciclaje. Su estructura es adaptable y puede expandirse según nuevas necesidades.
