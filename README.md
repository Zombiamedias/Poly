# Hola por este lado te dejo el cuestionario resuelto en lo que respondi
CUESTIONARIO

## 1. ¿Para que funciona el BoxCollider?
   R/ el box collider nos ayuda dandole un cuerpo fisico en donde puede colisionar de manera real como un objeto o donde conecte con su espacio para poder realizar  ejemplos HItBox o golpes como en juegos de pelea. es primpordial cuando un objeto que queremos comprobar o que queremos que haga algo como OnTriggerEnter nos de un evento cuando colisiona con otros objetos

## 3. ¿Qué funcionalidad tienen los Prefabs?
  Como su nombre lo dice son prefabricados que creamos para tener un modelo con una configuracion predeterminada a la hora de agregarlo en la escena, y su funcion 
## 4. ¿Qué rol cumplen los enum en C#?
son un tipo de dato que nos puede crear un conjunto de variables nuevas individuales, ejemplo 
` enum DiasDeLaSemana 
[  Lunes, Martes, Miercoles, Jueves, Viernes, Sabado, Domingo ]
`
## 5. ¿Para qué sirven los UnityWebRequest?
son clases de unity donde podemos usar los metodos HTTP, como lo son POST,GET, PUT, DELETE, se peude interactuar con API Restful de manera dinamica con ellos
## 6. ¿Para qué sirve un json?
Es un archivo plano para poder ser leido entre lenguajes de programacion, es muy util a la hora de tener datos planos y poder verlos en unity o javascript o en su caso mas comun en MYSQL o mongo }

## 7. ¿Qué resultados mostraría la consulta SELECT * FROM Simulación?
muestra todos los resultados de la tabla Simulacion ya que el asterisco se usa para que busque sin filtro dentro de esa tabla, es decir, mostraria todos los datos de la tala "silumacion" 
## 8. ¿Qué resultados mostraría la consulta SELECT COUNT(*) FROM Simulación?
aqui es parecido en lo del asterisco solo que en este caso mostraria todas los registros de la tabla Simulacion 
## 9. ¿Cómo sería la consulta si se quiere buscar datos de la tabla Simulación entre un rango de fechas?

seria con select * y su from de sumulacion y el where con la fechas poniendo el bewteen para el rango asi:
`SELECT * FROM Simulación WHERE Fecha BETWEEN '2024-01-01' AND '2024-12-31'`

## 10. ¿Como se eliminaría un registro en específico de la tabla Simulación?
Delete from Simulacion WHERE ID = # asi:
`DELETE FROM Simulación WHERE ID = 1;`

## 11. ¿Como actualizaríamos un registro en específico de la tabla Simulación?
usando el metodo UPDATE 
`UPDATE Simulación
SET Resultado = 'Aprobado', Estado = 'Activo'
WHERE ID = 1;`
