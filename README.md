# PriSecDBAAS

This repository will be used as a new PriSecDBAPI repository for the newly reworked PriSecDBAPI and the old PriSecDBAPI.
I will put some source code here whenever it's proven to have no bugs or issues.
The descriptions and things that I written in PriSecDBAPI will be rewritten here if I have time.

Temporary Server IP Address for reworked PriSecDBAPI: https://zeroaccesssecuritysolutions.com:5002/api/

**For details in reworked PriSecAPI, kindly go to the changelog.**

## Problem Statements
1. DBAAS does not have any encryption to begin with.
2. Any DBAAS encryption relies on private key or secret key to decrypt.
3. DBAAS does not provide any means to lock or unlock the client's db accounts.
4. DBAAS allows customization in exchange for security(SQL Injection)

## Unsolvable problem for all DBAAS
1. CRUD's R operation can be used as a DDOS attack.
2. Both the client db account and provider's admin account have admin privilege problem.
3. The connection string problem exists at both client's side and provider's side.
4. Data can be collected once it reached the provider side if the data was not pre-encrypted that can't be decrypt through https connection.

## Solutions to address(Partially ease) the problems
1. DBAAS must use an approach similar to asymmetric encryption or libsodium's sealedbox to encrypt client's data without sacrificing CPU usage on provider side.
2. DBAAS should provide a mean to lock or unlock the client's db accounts through public key authentication.
3. Strict SQL injection prevention should be in place through the use of stored procedures.
