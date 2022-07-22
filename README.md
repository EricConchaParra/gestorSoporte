## Soporte Manager
*Una Aplicación para manejar todas las conexiones SSH y SCP*

## Nota del autor
Se hace dificil manejar muchas conexiones y claves al dar soporte a usuarios con servidores Linux. Sobre todo si son clientes con multiples sucursales.
Es por ello que creé esta aplicación para poder contener la información en una sola fuente y que ésta fuente llame a todos los recursos que sean necesarios.

De momento permite conectar por SSH (Putty) y SCP (WinSCP) usando los usuarios y contraseñas guardados encriptados en una base de datos MySQL junto con almacenar datos relevantes de cada cliente/sucursal y un campo para notas.

Tiene mucho que mejorar, pero hasta ahora es útil y funcional. Lo construí hace bastante tiempo, por lo que se que puedo mejorar mucho el código... estaré actualizando.

## Consideraciones
- La carpeta `docs` tiene un un archivo JSON y un DLL que deben estar en la raíz del .exe para funcionar.

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

### 1.1.1 (20-07-2022)
- `user` y `pass` en el archivo config.json pueden estar encriptados o no estarlo, según el parámetro `encrypted` (asi no es necesario crear el string).
- Login ahora tiene hasta 5 reintentos por error (antes salía al primer fallo).
### 1.1.0 (18-07-2022)
- Reemplazado SQLite por archivo JSON para los datos de inicio de sesión.
- `user` y `pass` están encriptados por ahora.
    - Puedes usar la herramienta "encrypt" [disponible acá](https://github.com/EricConchaParra/encrypt/releases/download/Stable/Encriptador.exe) para crear el string encriptado.
- Próxima versión tendrá estos campos no encriptados.
