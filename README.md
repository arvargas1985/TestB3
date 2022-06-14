# Visão Geral

Esse documento visa informar as instruções para execução e testes da solução.

A solution está versionada em repositório público no GitHub sob a URL https://github.com/arvargas1985/TestB3.git. Para o desenvolvimento da WebApi e Tests foi utilizado o Microsoft .Net Framework 4.7.2

Os testes unitários da **TestB3.WebApi** (WebApi) podem ser encontrados na Solution **TestB3.sln** (\TestB3\SourceCode). Eles estão com o nome **TestB3.WebApi.Tests**, conforme imagem abaixo:
![plot](documents/01.png).

O testes seguiram os padrões MSTest (Microsoft.VisualStudio.TestTools.UnitTesting) com Injection Dependency (Microsoft.Extensions.DependencyInjection).

Para testes manuais deve-se usar o Postman para a chamada da WebApi. Inicialmente, antes de invocar a WebApi pelo Postman, é importante ressaltar que o projeto **TestB3.WebApi** deve estar rodando (modo Debug ou Release). A URL que deve ser informada no Postman para testar a WebApi é **https://localhost:44353/api/quotescdbs**, método POST, conforme imagem abaixo:
![plot](documents/02.png)

# Críticas

Gostaria de ter feito algo melhor, mas as exigências do cotidiano mais o fato da estafa impediram para o resultado ideal proposto. Ficando em a ver a entrega do projeto em Angular (sob pena de entregar "nas coxas" ou de qualquer jeito). Alguns fatores contribuiram para isso como por exemplo a falta de experiência em front-end desse desenvolver back-end que não tem perfil para Full-Stack (aliás, sempre por onde passou e teve que desempenhar tal função não conseguia entregar nem tão bem o back-end tampouco o front-end).

Normalmente, esse que vos escreve costuma declinar os convites de entrevistas técnicas que submetam a testes. A exceção dessa foi motivada pela a forma como a entrevista foi conduzida, ou seja, com cordialidade, respeito, transparência, gentileza, cortesia, empatia e humanidade. Esses itens fizeram com que o candidato arrumaasse um tempo que até ele não tinha (para tirar a prova dos 9, basta ver os horários dos commits)...

 A prova não estava difícil, a cabeça, a mente e o corpo do candidato que andam muito esgotados (sinais de uma pandemia em que estamos em uma socidade cada vez mais doente e depressiva mais o fato de já estar a há mais de 2 anos sem férias), fatos esses que contribuiram para que o candidato se achasse, pois estava há 6 meses sem praticar o conteúdo (impressionante isso...). Até um tempo atrás, esse texto bem como essas palavras seriam consideradas irrelevantes para a entrevista (há um tempo atrás seria considerado motivo para eliminação sumária do candidato, mas ainda bem que os tempos mudam...), mas dessa vez resolvi escrever, não para justificar falhas, e sim para apontar fatos.

Falando em primeira pessoal do plural, precisamos ser feliz e SEREMOS!