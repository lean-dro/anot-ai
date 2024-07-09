*Em desenvolvimento

# anot-ai
O anot-ai é um projeto com a premissa de facilitar e otimizar as anotações do cotidiano. 
Integrado ao Gemini, permite que uma simples anotação possa ser convertida ao modelo SMART, tornando ela mais específica e alcançável.

### Exemplo:

Anotação de entrada:
```json
{
  "descricao": "Estudar sobre cluster e análise de dados",
  "dataPrazo": "2024-07-30T03:45:10.899Z"
}
```
Anotação de saída:
```json
"descricao": "Estudar sobre cluster e análise de dados",
	"dataCriacao": "2024-07-06T00:57:26.6184285",
	"dataPrazo": "2024-07-30T03:45:10.899",
	"smart": {
		"specific": "Compreender os conceitos básicos de clusterização de dados, incluindo técnicas como K-means, hierárquica e densidade.",
		"measurable": "Concluir um curso online sobre análise de cluster, realizando todos os exercícios e obtendo uma pontuação de pelo menos 80%.",
		"achievable": "Aprender através de cursos online, livros e tutoriais disponíveis gratuitamente na internet. Será necessário dedicar cerca de 10 horas por semana ao estudo.",
		"relevant": "Compreender os conceitos de clusterização é fundamental para a análise de dados, permitindo a identificação de padrões e agrupamentos em grandes conjuntos de dados, o que facilita a tomada de decisões mais precisas e eficazes.",
		"time": "30/07/2024 03:45:10"
	},
	"monitoramento": {
		"check": "Verificar o certificado de conclusão do curso e a pontuação obtida. Avaliar o nível de conhecimento adquirido através da realização de exercícios práticos e análise de exemplos de clusterização de dados."
	},
	"planoAcao": {
		"etapas": [
			{
				"numeroEtapa": 1,
				"acao": "Selecionar um curso online sobre clusterização de dados.",
				"detalhes": "Pesquisar em plataformas como Coursera, edX, Udemy e Khan Academy por cursos com boas avaliações e que se adaptem ao nível de conhecimento atual."
			},
			{
				"numeroEtapa": 2,
				"acao": "Iniciar o curso online e acompanhar as aulas com atenção.",
				"detalhes": "Fazer anotações importantes, tirar dúvidas com o instrutor ou em fóruns de discussão e praticar os exercícios propostos."
			},
			{
				"numeroEtapa": 3,
				"acao": "Completar os exercícios e projetos práticos do curso.",
				"detalhes": "Utilizar ferramentas como Python e bibliotecas como scikit-learn para implementar algoritmos de clusterização e analisar os resultados."
			},
			{
				"numeroEtapa": 4,
				"acao": "Revisar o material do curso e praticar os conceitos aprendidos.",
				"detalhes": "Realizar exercícios adicionais e consultar recursos extras, como livros e artigos científicos, para aprofundar o conhecimento."
			},
			{
				"numeroEtapa": 5,
				"acao": "Concluir o curso online e obter uma pontuação de pelo menos 80%.",
				"detalhes": "Revisar o material do curso e realizar os exercícios de avaliação final para alcançar a pontuação desejada."
			}
		]
	}
```
