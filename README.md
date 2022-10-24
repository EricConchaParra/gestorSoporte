## Soporte Manager
*Aplicación de escritorio para manejo de eventos de soporte que requieren cronometrar la atención, y realizar conexiones via SSH, transferencia de archivos via SCP y conexiónes de Escritorio Remoto (RDP)*

Inicio de Sesión

![image](https://user-images.githubusercontent.com/85537653/184450629-f51d652c-57bf-4d82-b761-c12586bad61c.png)

Listado de clientes, busqueda rápida

![image](https://user-images.githubusercontent.com/85537653/184450681-82d5998d-5273-44a8-9d2d-49ee708a85d2.png)

Panel de Control

![image](https://user-images.githubusercontent.com/85537653/184450717-84ce4d78-8b0a-4db5-8e7c-7ae495859a1e.png)

Bóveda de claves

![image](https://user-images.githubusercontent.com/85537653/184451558-67b54886-bd70-4607-9637-fa6922909c47.png)

## Descripción
Se hace dificil manejar muchas conexiones y claves al dar soporte a usuarios con servidores Linux/Windows. Sobre todo si son clientes con multiples sucursales.
Es por ello que creé esta aplicación para poder contener la información en una sola fuente y que ésta fuente llame a todos los recursos que sean necesarios.

Esta aplicación permite:

- Conectar por SSH (Putty), SCP (WinSCP) y RDP (Conexión a Escritorio Remoto) usando los usuarios y contraseñas guardados encriptados en una base de datos MySQL
- Almacenar datos relevantes de cada cliente/sucursal y un campo para notas.
- Envío de updates del soporte a través de `Slack`. Las notificaciones incluyen el estado del soporte, identificación del funcionario y cliente, tiempo transcurrido y un espacio para notas.
- Al terminar el soporte (y si está configurado para ello), el usuario podrá escribir en una `base de datos de Notion` el evento y dejar así un registro para el equipo (y futuras referencias).

_Este proyecto está en constante desarrollo_


## Consideraciones
- De momento no existe una versión "instalable" de esta aplicación.

## Archivos de Configuración
En la carpeta donde se encuetra el .exe, se debe existir un archivo llamado config.json. Dentro tendrá la siguiente estructura:
```json
{
  "encrypted" : "0",
  "key" : "ENTERYOURKEY",
  "ip" : "192.168.2.11",
  "puerto" : "3306",
  "user" : "MIUSER",
  "pass" : "MIPASS",
  "database" : "s_manager"
}
```
`encripted` : `"0"` indica que `user` y `pass` no están encriptados (solo aplica en este archivo). Si `"1"` entonces datos están encriptados usando la `key` indicada.

`key`: Clave que se utiliza para la encriptación de la información en Base de Datos y en este archivo el `user` y `pass`

## Documentación
- Puedes usar la herramienta "encrypt" [disponible acá](https://github.com/EricConchaParra/encrypt/releases/download/Stable/Encriptador.exe) para crear el string encriptado ([ver código en GitHub](https://github.com/EricConchaParra/encrypt))

## Versiones
## 2.6.0
- Integración con Sigue® ERP para la notificación de documentos impagos y el envío de estados de cuenta junto con las notas de la atención.
  - Se pueden definir IDs adicionales al principal (R.U.T.) para consultarlos todos y entregar información más completa

## 2.5.0
- Integradas las notificaciones por correo electrónico al cliente. Se utiliza un servicio SMTP que debe ser configurado por el administrador.
- Se define si habrá notificaciones disponibles o no y a qué correos deben ser enviadas en el registro del cliente (no de sucursal).

### 2.3.1 (10-09-2022)
- Añadido URL para cada contraseña, también puedes copiar usuario, pass y URL con un clic.
- Añadido "Origen" a descripción del evento de soporte. Ésto permite mejorar las estadísticas obtenidas desde la base de datos de Notion, a fin de analizar si el servicio tuvo su origen por bug, problemas de plataforma, a solicitud del cliente o parte del mantenimiento (por contrato).

### 2.3.0 (11-08-2022)
- Añadido un gestor de contraseñas propio para cada cliente.
- Puedes guardar Descripción, usuario y contraseña para cada cliente y tenerlas disponibles
en el Panel de Control. 
- Los datos se guardan encriptados en la base de datos MySQL.

### 2.2.0 (08-08-2022)
- Puedes editar la lista del equipo de soporte

### 2.1.0 (04-08-2022)
- El contador de tiempo de soporte comienza automáticamente cuando al cliente.
- Si finalizas un evento se cierra la ventana (no hay que hacerlo manualmente)
- Volvieron los controles de minimizar, y Cerrar arriba a la derecha (se habían quitado)
- Corrección de Bugs
- Mucho mas espacio para escribir las descripciones de los eventos

### 2.0.0 (01-08-2022)
- Control de tiempo de soporte por cliente (cronómetro)
- Registro de notas del evento de soporte
- Conexión a Slack via API para notificación de eventos de soporte
- Conexión a Notion via API para registro de eventos de soporte en base de datos
- Los datos para conexión segura se guardan encriptados en la DB
### 1.1.1 (20-07-2022)
- `user` y `pass` en el archivo config.json pueden estar encriptados o no estarlo, según el parámetro `encrypted` (asi no es necesario crear el string).
- Login ahora tiene hasta 5 reintentos por error (antes salía al primer fallo).
### 1.1.0 (18-07-2022)
- Reemplazado SQLite por archivo JSON para los datos de inicio de sesión.
- `user` y `pass` están encriptados por ahora.
    - Puedes usar la herramienta "encrypt" [disponible acá](https://github.com/EricConchaParra/encrypt/releases/download/Stable/Encriptador.exe) para crear el string encriptado.
- Próxima versión tendrá estos campos no encriptados.
