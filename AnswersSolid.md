# Aplicando SOLID al proyecto de Shapes

Aplicado Single Responsability Principle y Open Close Principle
Falta -> LSP, ISP y DIP.

## Aplicando SOLID

Contar Areas

Contar Esquinas

Contar EstadosDeAnimoDelasFormas // Bit complicate!!

Motor de las formas (ShapeEngine)
Tendrá:
Un Logger
Un creador de la lista de formas
Recuperador del fichero en disco (json) con la lista de formas a crear
Deserializar la jerarquia de clases (JSON con deserialización de polimorfismos)
Una Factoria, para que podamos pasar la lista de formas y realizar las operaciones

El motor de las formas debe tener una colección o lista de formas

El motor de formas debe llamar a la factoría para
 1 - Contar Areas
 2 - Contar Esquinas
 3 - Contar los estados de animo

El último proceso el 3 debera pernsarse con mas cuidado

