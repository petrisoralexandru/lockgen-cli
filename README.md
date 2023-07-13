![Lockgen CLI](https://github.com/petrisoralexandru/lockgen-cli/assets/34144926/f9735f3b-ec11-4b5c-aa14-6c28392e0582)
# LockGen - Say goodbye to weak passwords and hello to ultimate protection
- LockGen is a password generation tool using the console as a graphical environment, developed in the C# programming language. With this project, secure and random passwords can be generated instantly, giving control over password security.
- LockGen uses a powerful password generation method to ensure high-quality results. The user specifies various generation criteria, such as password length, inclusion of special characters, capital letters and digits, to obtain passwords that meet the user's security requirements.

## Features
- Instant generation of secure and random passwords
- Full control over password security
- Use custom criteria to generate passwords
- Powerful password generation method for high quality results

## How it works
![LockgenShowcase](https://github.com/petrisoralexandru/lockgen-cli/assets/34144926/3ebe521c-32a0-4d99-9fdb-54149c71ec4a)

1. The program starts its execution by prompting the user, after which they are given advice on password length.
2. The program requires the user to specify, step by step, the length of the password, whether the password should include uppercase, lowercase, digits and special characters.
3. User preferences for password specifications are passed to the method responsible for generating the password.  Depending on the user's password preferences, checks will be made to include different subsets of characters (uppercase, lowercase, digits, special characters). For random selection of characters from the final character set, the `RandomNumberGenerator` class from the `System.Security.Cryptography` will be used, specially designed by Microsoft, for such randomised generation.
4. The password is displayed on the screen.
5. The password is automatically copied to the clipboard.
6. The application closes automatically.

## How to compile the application
1. Clone or download this project to your computer.
2. Open the project in the C# development environment (e.g: Visual Studio, Visual Studio Code or Jetbrains Rider).
3. Compile and run the project with the F5 key.
4. In the console, follow the instructions to specify the password generation criteria.
5. Once the criteria are set, you will instantly receive a randomly generated password that meets your requirements.

## Package used

| Name                                     | Utility | Released Package |
|------------------------------------------|------------------| --------|
| TextCopy                    | Ability to copy text to clipboard | [![TextCopy Badge](https://buildstats.info/nuget/TextCopy)](https://www.nuget.org/packages/TextCopy) |

## Contribution
Contributions are welcome! If you would like to contribute to the development of this project, please follow the steps below:
1. Fork this repository.
2. Create a new branch for the functionality you are adding: `git checkout -b feature/new-function`.
3. Implement and test new functionality.
4. Commit changes: `git commit -m "Add new function"`.
5. Submit changes to your repository: `git push origin feature/new-feature`.
6. Open a Pull Request in this repository.

## Questions or Suggestions
If you have any questions or suggestions about LockGen, please open an [issue](https://github.com/petrisoralexandru/lockgen-cli/issues) in this repository. I'll be happy to help you or get your constructive feedback.

## License
This project is licensed under the [MIT license](https://github.com/petrisoralexandru/lockgen-cli/blob/main/LICENSE). Please cite this source and abide by the license terms when using this project.
