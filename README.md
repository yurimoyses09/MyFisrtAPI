# MyFisrtAPI
Example of the API using C#

For execute this API fist you need access this link https://drive.google.com/drive/folders/1DHGz6JzqSvgsz-GSQj1uWU4JfNyIgjJl?usp=sharing and execute the query.

After enough you download a project and run

Obs: This API only runs the GET method and PUT, passing ID by parameter and a json

# Example Method GET: 
On PostMan you need set this URL https://localhost:5001/api/Funcionarios/id?id=38, but remember that you need set the id specific, in this example it is 38.

The return it is something like this: 
{
    "IdFuncionario": 4,
    "Nome": "Carlos",
    "Email": "Carlos@rediff.com",
    "Sexo": "Masculino",
    "Departamento": "Saude",
    "Admissao": "09/09/2012",
    "Salario": 4000,
    "Cargo": "Ortopedista",
    "Estado": "Sao Paulo"
}

# Example Method PUT:
URL https://localhost:5001/api/Funcionarios/jsonfuncionario/?jsonfuncionario={YOURJSON}

On PostMan you need access this option "Params", then you need to put the key (jsonfuncionario), then insert in the VALUE field the json with the information to be inserted in the database, in the same format as above.

If no error has occurred, this return message will appear "OK"
