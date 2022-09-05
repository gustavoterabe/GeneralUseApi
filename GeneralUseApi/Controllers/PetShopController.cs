using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text.Json;

namespace GeneralUseApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PetShopController : ControllerBase
    {
        
        private readonly ILogger<PetShopController> _logger;

        public PetShopController(ILogger<PetShopController> logger)
        {
            _logger = logger;
        }

        [Route("v1/pets")]
        [HttpGet]
        public string GetPets()
        {
            return "";
        }
        
        [Route("v1/products")]
        [HttpGet]
        public string GetProducts()
        {
            return "[\n    {\n        \"_id\":\"481598b848f447b4b923ca2ad405aa09\",\n        \"title\":\"Cama M1 Urban\",\n        \"category\":\"accessories\",\n        \"description\":\"<ul><li><span><b>Pet:</b></span><span> Cachorros</span></li><li><span><b>Porte de Raça:</b></span><span> Grande, Médio e Pequeno</span></li><li><span><b>Idade:</b></span><span> Sênior, Adulto e Filhote</span></li><li><span><b>Material:</b></span><span> Plástico</span></li><li><span><b>Medidas<br>aproximadas:</b></span><span> Tamanho 8 (84 x 59,5 x h 25 cm), Tamanho 6 (70,5 x 52 x h 23,5 cm), Tamanho 4 (61,5 x 45 x h 21,5 cm), Tamanho 2 (52 x 36 x h 17,5 cm), Tamanho 12 (111 x 80,5 x h 33,5 cm), Tamanho 10 (93,5 x 68 x h 28 e5 cm)</span></li><li><span><b>Tipo:</b></span><span> Cama</span></li><li><span><b>Cor:</b></span><span> Bordô</span></li><li><span><b>Apresentação:</b></span><span> <p><span>Disponível nos tamanhos 2, 4, 6, 8, 10 e 12</span></p></span></li><li><span><b>Código de barras:</b></span><span> 8010690074689</span></li></ul>\",\n        \"price\":5999,\n        \"images\":[\n            \"https://baltaio.blob.core.windows.net/courses/7180/cama-m1-urban-puppy.jpg\"\n        ]\n    },\n    {\n        \"_id\":\"481598b848f447b4b923ca2ad405aa10\",\n        \"title\":\"Ração Golden Special Sabor Frango e Carne para Cães Adultos\",\n        \"category\":\"food\",\n        \"description\":\"<p>- Indicado para cães adultos;<br>- Livre de corantes e aromatizantes artificiais;<br>- Alimento rico em nutrientes;<br>- Promove o equilíbrio intestinal;<br>- Protege as articulações;<br>- Disponível em embalagens de 15kg e 20kg.</p>\",\n        \"price\":10490,\n        \"images\":[\n            \"https://baltaio.blob.core.windows.net/courses/7180/racao-golden.png\"\n        ]\n    },\n    {\n        \"_id\":\"481598b848f447b4b923ca2ad405aa11\",\n        \"title\":\"Ração Royal Canin Golden Retriever - Cães Adultos - 12kg\",\n        \"category\":\"food\",\n        \"description\":\"<p>- Indicada para cães adultos; <br>- Específica para pets da raça Golden Retriever; <br>- Auxilia na manutenção do peso ideal; <br>- Mantém a saúde da musculatura cardíaca; <br>- Proporciona uma pele e pelagem mais saudáveis,<br>- Disponível em embalagem de 12kg. </p>\",\n        \"price\":21999,\n        \"images\":[\n            \"https://baltaio.blob.core.windows.net/courses/7180/racao-royal-canin.png\"\n        ]\n    }\n]";
        }

        [Route("v1/accounts/authenticate")]
        [HttpPost]
        public string Authenticate(string? uuid, string? key, string? value)
        {
            return "{\n    \"customer\":{\n        \"_id\":\"e064caf4b91e4d908a388a734a34feb3\",\n        \"name\":\"Bruce Wayne\",\n        \"document\":\"04052789008\",\n        \"email\":\"customer@petshop.com\"\n    },\n    \"token\": \"eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjVjODkwMzM4YjljMWYyNDI0Y2E2NDVmZCIsImVtYWlsIjoiYW5kcmViYWx0aWVyaUBnbWFpbC5jb20iLCJuYW1lIjoiQW5kcsOpIEJhbHRpZXJpIiwiZG9jdW1lbnQiOiIzNTI5MjYyMzgyMiIsInN1YnNjcmliZXIiOnRydWUsImlhdCI6MTU1NDMyMTg3MiwiZXhwIjoxNTU0NDA4MjcyfQ.YLS527i8yXnimL15jPyT8mkFAOYI7yorqh-zQyHq-N0\"\n}";
        }

        [Route("v1/accounts/refresh-token")]
        [HttpPost]
        public string RefreshToken(string? uuid, string? key, string? value)
        {
            return "{\n    \"customer\":{\n        \"_id\":\"e064caf4b91e4d908a388a734a34feb3\",\n        \"name\":\"Bruce Wayne\",\n        \"document\":\"04052789008\",\n        \"email\":\"customer@petshop.com\"\n    },\n    \"token\": \"eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjVjODkwMzM4YjljMWYyNDI0Y2E2NDVmZCIsImVtYWlsIjoiYW5kcmViYWx0aWVyaUBnbWFpbC5jb20iLCJuYW1lIjoiQW5kcsOpIEJhbHRpZXJpIiwiZG9jdW1lbnQiOiIzNTI5MjYyMzgyMiIsInN1YnNjcmliZXIiOnRydWUsImlhdCI6MTU1NDMyMTg3MiwiZXhwIjoxNTU0NDA4MjcyfQ.YLS527i8yXnimL15jPyT8mkFAOYI7yorqh-zQyHq-N0\"\n}";
        }
    }
}
