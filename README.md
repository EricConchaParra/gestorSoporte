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
  "ip" : "192.168.2.11",
  "puerto" : "3306",
  "user" : "MIUSER",
  "pass" : "MIPASS",
  "database" : "smanager"
}
```
**debug**: `0` sin debug. `1` se muestran mensajes de debug.

## Documentación
Por construir
