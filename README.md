# Reto Técnico de Suiza Lab
### Requerimiento
- Crear un proyecto en .net Core
- Generar una lista de personas
- Crear un EndPoint que devuelva aleatoriamente los datos de una Persona
- Crear un EndPoint que regrese las personas por genero
- Usar la Injeccion de dependencia
----------------------
### Inforomación
### End Points
Persona Aleatoriamente - {controller}
```
http://localhost:5144/persona
```
Personas Agrupadas por Sexo  {controller}/{sexo} 
```
http://localhost:5144/persona/T
```
Valores para Sexo: 
 M F T
en el caso de T devolvera un JSON con los grupos de personas separadas por los generos
