## Soporte Manager
*Aplicación de escritorio para manejo de eventos de soporte que requieren cronometrar la atención, y realizar conexiones via SSH, transferencia de archivos via SCP y conexiónes de Escritorio Remoto (RDP)*

## Nota del autor
Se hace dificil manejar muchas conexiones y claves al dar soporte a usuarios con servidores Linux/Windows. Sobre todo si son clientes con multiples sucursales.
Es por ello que creé esta aplicación para poder contener la información en una sola fuente y que ésta fuente llame a todos los recursos que sean necesarios.

Esta aplicación permite conectar por SSH (Putty), SCP (WinSCP) y RDP (Conexión a Escritorio Remoto) usando los usuarios y contraseñas guardados encriptados en una base de datos MySQL junto con almacenar datos relevantes de cada cliente/sucursal y un campo para notas.

Además al realizar un soporte puedes hacer el envío de notificaciones a tu equipo a través de Slack. Las notificaciones incluyen el estado del soporte, identificación del funcionario, tiempo transcurrido y un espacio para notas.

Al terminar el soporte (y si está configurado para ello), el usuario podrá escribir en una base de datos de Notion el evento y dejar así un registro para el equipo (y futuras referencias).

*Este es un proyecto en desarrollo*


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
