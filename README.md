# Sistema de Telediagnóstico Médico
Para poder utilizar este software es necesario tener la base de datos creada y con un mínimo de juego de datos cargados.  
  
[Descarga el script de creación de la base de datos](https://drive.google.com/file/d/1Wa-81Zs0v3jUI-lFl-98kFYDzePanjoe/view?usp=sharing).  
[Descarga el script con juego de datos](https://drive.google.com/file/d/1E0IeifHZ-bJKOj9EIEuKCc4xhb1Sn0cf/view?usp=sharing).
  
## Remarks
El software está configurado para acceder a un servidor remoto, mediante una data source name (dsn) de ODBC, y no de manera local. Se deberá cambiar esta configuración para poder hacer uso del sistema.
---

## Usuarios del Sistema

| CI       | Password | Tipo de Usuario |
|----------|----------|-----------------|
| 11111111 | 123 | Paciente |
| 12121212 | 123 | Médico |
| 12121212 | 123 | Administrador |
| 31541142 | 123 | RRHH |
| 23520049 | 123 | Recepcionista |

---

## Aplicación de Gestión
### Síntomas
* [X] Alta Síntoma
* [X] Modificacación de Síntoma
* [X] Baja Síntoma
* [X] Listar Síntomas
* [X] Búscar Síntoma
* [ ] Importar Síntomas

### Enfermedades
* [X] Alta Enfermedad
* [X] Modificación de Enfermedad
* [X] Baja Enfermedad
* [X] Listar Enfermedades
* [X] Buscar Enfermedades
* [ ] Importar Enfermedades

### Usuarios
##### Empleados
* [X] Alta Empleado (Medico, Recursos Humanos, Recepcionista)
* [X] Modificación Empleado
* [X] Baja Empleado
* [X] Extender permisos a Médicos
* [X] Listar Empleados
* [ ] Buscar Empleados

#### Pacientes
* [X] Alta Completa Pacientes
* [X] Alta Parcial Pacientes
* [X] Modificación Pacientes
* [X] Baja Pacientes
* [X] Listar Pacientes
* [ ] Buscar Pacientes

## Aplicación Paciente
* [X] Seleccionar síntomas
* [X] Obtener Diagnóstico
* [ ] Ver HCE
* [X] Iniciar Chat
* [ ] Enviar copia chat por mail
* [ ] Establecer contraseña

## Aplicación Médico
* [X] Ver solicitudes de chat
* [X] Iniciar chat
* [ ] Ver HCE paciente
* [ ] Establecer contraseña
