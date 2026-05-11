# DEMOFuncionalInventario-Stock
Dejo todo aca de la demo para el tp de PA I muchachos

NOTA IMPORTANTE
Es un proyecto que consta de 2 servicios, uno para el servidor donde esta el stock, y el otro del cliente que es para consultar la disponibilidad, por lo que ambos deben ejecutarse a la vez.
Esto es algo que VS por defecto no hace.
Una vez clonado, ejecutar el archivo ProyectoGrpc.slnx, una vez abierto VS, ubicar el explorador de soluciones hacer click derecho en la solucion e ir a propiedades.
En propiedades comunes -> Configurar proyectos de inicio se debe seleccionar "varios proyectos de inicio" y configurar como accion en AMBOS proyectos la opcion "inicio". 
Una vez confirmados los cambios, prueba ejecutar la solucion, deberia abrir dos consolas, una con el servidor HTTPS esperando la instruccion de la consola, y otra con el cliente que es el unico con el que deben interactuar.
