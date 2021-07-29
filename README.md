# MyFisrtAPI
Example of the API using C#

For execute this API fist you need access this link https://drive.google.com/drive/folders/1DHGz6JzqSvgsz-GSQj1uWU4JfNyIgjJl?usp=sharing and execute the query.

After enough you download a project and run

# Example Method GET: 
When running the API you will notice that you will open a swagger page in the browser, and on this screen you will have all the API methods, with their appropriate URLs.
In this same screen, select the get method, and inform the Id, but before clicking on Try it Out.

The return it is something like this: 
{"IdFuncionario":2,"Nome":"Yuri","Email":"Yuri@rediff.com","Sexo":"Masculino","Departamento":"TI","Admissao":"21/09/2020","Salario":3500,"Cargo":"Analista","Estado":"Sao Paulo"}

# Example Method PUT:
On the same swagger screen, to test the PUT method you need to put a json in the same format:
{
    "Nome": "Name",
    "Email": "Email",
    "Sexo": "Sex",
    "Departamento": "Departament",
    "Admissao": "DateAdmission",
    "Salario": 1000,
    "Cargo": "Office",
    "Estado": "State"
}
If no error has occurred, this return message will appear "OK"

# Example Method DELETE:
first you need to run the api, then just inform the id of the employee you want to delete
Se nenhum erro ocorrer o retorno sera "OK - Deletado"
