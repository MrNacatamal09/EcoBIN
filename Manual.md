# Manual de Usuario.

MANUAL DE USUARIO DEL SISTEMA ECOBIN

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------
Introducción


Este manual describe detalladamente el funcionamiento de EcoBIN y explica el uso de cada una de sus ventanas. Está dirigido a usuarios comunes y administradores.


---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Inicio del sistema


Al ejecutar EcoBIN se muestra la ventana de inicio de sesión.

Inicio de sesión


Se deben ingresar tres datos


• CIF compuesto por ocho dígitos numéricos.


• Nombre del usuario.


• Contraseña.

Si el CIF no existe, el sistema registra automáticamente al usuario como Usuario.


Si el CIF existe, el sistema valida el nombre y contraseña antes de permitir el acceso.


---------------------------------------------------------------------------------------------------------------------------------------------------

Pantalla principal del menú


Una vez dentro del sistema, se presenta el menú de opciones. Las funciones disponibles dependerán del rol.



------------------------------------------------------------------------------------------------------------------------------------------------------



🙋‍♀️ Opciones disponibles para usuario común




• Registro de materiales a reciclar


Permite ingresar el tipo de material, su peso en libras y registrar la acción.


El sistema calcula los puntos según el material y actualiza el archivo de registros.


Al ingresar, se muestra una frase motivacional de manera aleatoria.





• Consulta de puntos


Muestra los puntos totales del usuario, el historial completo de registros realizados y los movimientos de canjes.


Cada movimiento señala fecha, material, peso y puntos sumados o restados.





• Ranking general


Despliega un cuadro organizado con los primeros diez usuarios con mayor puntuación.


Muestra posición, nombre, mejor material reciclado, puntos obtenidos por dicho material y total acumulado.


El usuario común puede visualizar el ranking, pero no regresar al menú desde esta ventana mediante el botón oculto para ellos.



• Canje de puntos


Desde la ventana de consulta, se permite seleccionar un beneficio de una lista desplegable y descontar los puntos necesarios.


La acción queda registrada en el historial de movimientos.



-------------------------------------------------------------------------------------------------------------------------------------------------

👤 Opciones exclusivas del administrador


• Actualizar usuario


Solicita un CIF, carga la información del usuario y permite editar nombre y contraseña.




• Eliminar usuario


Solicita un CIF y elimina al usuario, su historial de reciclaje y su historial de canjes.


No se permite borrar al propio administrador mientras esté en uso.




• Reportes EcoBIN


La ventana de reportes está diseñada para generar 2 secciones de reportes que incluyen, según la configuración, resumen por material y resumen por usuario


-----------------------------------------------------------------------------------------------------------------------------------------------------------------------


Resumen de materiales reciclados


Totales por usuario


Canjes realizados


Podrá expandirse con filtros por fecha mediante DateTimePicker u otros criterios.


Solo el administrador tiene acceso a esta ventana.



------------------------------------------------------------------------------------------------------------------------------------------------------------------



Restricciones de seguridad según rol


• El administrador no puede registrar materiales.


• El administrador no puede realizar canjes.


• El administrador no tiene historial de puntos.


• El usuario común no puede acceder a administración ni reportes.


• El usuario común no puede ver el menú de opciones dentro de RankingGeneral.


----------------------------------------------------------------------------------------------------------------------------------------------------------------------

Cierre de sesión


Desde cualquier ventana donde esté disponible la opción Salir, el usuario puede cerrar sesión y volver al inicio.



------------------------------------------------------------------------------------------------------------------------------------------------------------------------




Consejos de uso


Es recomendable ingresar datos reales para mantener un control adecuado de los registros.


Si el sistema no encuentra archivos, los crea automáticamente.


Para evitar errores, no manipular manualmente los archivos de texto.




-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------



Soporte y ampliación


El sistema está diseñado para ser ampliado fácilmente, permitiendo agregar nuevos materiales, beneficios, roles o módulos de análisis. 


Si se desean añadir funciones, deben respetarse las estructuras de los archivos y servicios existentes.
