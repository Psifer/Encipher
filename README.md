# Encipher
**Disclaimer** This was an exercise to help me learn aspects of C#. There are currently security flaws present given the nature of how the data is stored. Do not entrust this program with your utmost confidential information. It can be adapted to follow common practice of keeping the encryption keys seperate of the encrypted data.

Encipher is C# Windows Form App where you can store your user login information offline. Encipher incorporates Google Authenticator to login into the program.

![alt text](https://github.com/Psifer/Encipher/blob/master/PasswordSaver/EncipherImages/encipher%20createaccount%20page.png)![alt text](https://github.com/Psifer/Encipher/blob/master/PasswordSaver/EncipherImages/encipher%20login%20page.png)

Encipher encrypts the user inputted data into AES-256 bit encryption which is then saved on the local database created by the program.
The confidential information can then be revealed by clicking on the decrypt button where it displays the decrypted information but does
not save the exposed info to the database.
![alt text](https://github.com/Psifer/Encipher/blob/master/PasswordSaver/EncipherImages/encipher%20passSaver%20page.png)
![alt text](https://github.com/Psifer/Encipher/blob/master/PasswordSaver/EncipherImages/encipher%20passSaver%20page1.png)
![alt text](https://github.com/Psifer/Encipher/blob/master/PasswordSaver/EncipherImages/encipher%20passSaver%20page2.png)

Encipher also includes a password generator where you can select the type of character and length of password. Allowing
for optimal security if you create a new random password for each website account you create.
![alt text](https://github.com/Psifer/Encipher/blob/master/PasswordSaver/EncipherImages/encipher%20pasgen%20page.png)
