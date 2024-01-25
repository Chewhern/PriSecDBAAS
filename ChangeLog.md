# Notice
This changelog will only be responsible for the reworked version of the old PriSecDBAPI. The non reworked and reworked versino of PriSecDBAPI, kindly understand that, the provider holds no private key to decrypt
the content within the client's database. The private key will be generated and stored only on client's device.

## Server App

### Version 0.0.1
-> Removed **X3DH** sealed encryption from CRU(Create,Read,Update) operations.\
-> Removed single field select,update and delete operations.\
-> **Create Database, Database User and grant operations now uses terminal/command prompt/console to perform.**\
-> ETLS and Sealed ETLS now uses sealedbox concept with domain separation.\
-> Sealedbox like encryption on per column's data now enforces basic domain separation.\
-> Now supports 4 Stream Cipher algorithms(XChaCha20,XSalsa20,AES256GCM,SM4-CTR) and 7 MAC algorithms(HMAC-SHA512,Keyed-Blake2B,Poly1305,KMAC,Keccak[MACKey|Message],SHAKE[MACKey|Message],HMAC-SM3).
-> Due to the enforcement of net neutrality, payment gateways weren't implemented by default.

## Client/Side
The older version of PriSecDBAPI on the client side is using windows GUI and library to enable smoother client operations. Reworked version of PriSecDBAPI on the client side now uses AvaloniaUI which is a 
.Net Core or .Net Standard library that uses Google's skia library to provide cross platform native UI development and deployment. However, due to insufficient capabilities and busy schedule, the applications
on client side before they actually deployed in live environment(on client side), all the assistance operations and guidance operations can only be supported on cross platform desktop OS such as Linux, Windows
and MacOS. The screen resolution that the applications were developed on is 1920*1080.

Any client device that don't fulfill such a resolution will find the UI not responsive and tidy.

## Admin App (Provider)

### Version 0.0.1
-> Generates mutable cryptographic key pair in the form of Byte[] or uint_8[] or uint_8* or unsigned char* and stores it in files.\
-> Enforce net neutrality by default.\
-> Identity binding will be enabled by default. Such binding requires both the provider and user to be online simultaneously, the binding is required in order for the credentials generation on the client side.\
-> All operations on the admin side is done by using challenge and response authentication.

## Developer/DBA App
In order to use this to its fullest, the developer must possess certain advanced skills in DBA. In the same time, the developer is advised to have skills in unmanaged server environment along with their preferred
programming language of choice.

Due to the characteristic of such DBAAS, it'll always be better if there's an intranet server and the key exchange private key from DB Credentials folder/directory in CAdminApp was
directly stored within the intranet server and all operations were being done by using intranet server web API for operations.

Despite there's many programming languages and the fact that this DBAAS is a web API application, when consuming it for normal CRUD operations, the preferred programming languages will always be Java,C#,C and
C++. PHP may be supported but there's no full guarantee on that. This statement is a combined factors of libsodium binding/wrapper library in the targeted language. If the wrapper library is severely outdated,
then the developer have to know how to create their own wrapper/binding library for that particular programming language.
