# 🌐 ProjectConsultasDNS

Una herramienta interactiva de consola desarrollada en C# (.NET) que permite consultar las direcciones IP asociadas a cualquier dominio de internet utilizando el sistema DNS, manteniendo un historial automático en un archivo de texto.

## 🚀 Características

- *Consultas infinitas:* Permite realizar múltiples búsquedas consecutivas sin que el programa se cierre.
- *Historial persistente:* Guarda automáticamente cada consulta exitosa con fecha y hora en un archivo local.
- *Control de errores robusto:* Evita cierres inesperados si el dominio no existe o si no hay conexión a internet.

## 🛠️ Explicación Técnica (Código Limpio)

El sistema utiliza las siguientes librerías de .NET:
- System.Net: Para la resolución de nombres de dominio e infraestructura de red.
- System.IO: Para la persistencia y manipulación del archivo de texto en el disco duro.

### 📋 Variables Clave
- rutaArchivo (string): Define el nombre y ubicación del archivo de texto (historial_dns.txt) donde se guarda el historial.
- dominio (string): Captura de forma segura el texto que el usuario ingresa por teclado.
- direcciones (IPAddress[]): Un arreglo que almacena la lista de IPs devueltas por el servidor DNS.
- registro (string): Cadena con formato que prepara los datos de la consulta antes de guardarlos.

### ⚙️ Métodos Principales Utilizados
- Dns.GetHostAddresses(dominio): Método de red que realiza la consulta DNS real en internet.
- File.AppendAllText(rutaArchivo, registro): Escribe los datos en el archivo sin sobrescribir las consultas previas.
- Console.ReadLine(): Captura la entrada del usuario en la consola.
- dominio.ToLower(): Normaliza el texto a minúsculas para evaluar de forma segura la palabra de salida ('salir').

## 📂 Estructura del Historial

El archivo historial_dns.txt se genera en la carpeta raíz del ejecutable (/bin/Debug/netX.0/) con el siguiente formato cronológico:

text
--- Consulta: google.com ---
142.250.190.46
142.250.191.110


## ⚙️ Requisitos

- .NET SDK (Versión 6.0 o superior recomendada)
- Un IDE como Visual Studio o Visual Studio Code
