using MesOutils;
using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace PileObjet.Utilitaires
{
    class UtilitaireAPI
    {
        public static String RecupereLoremIpsum(int nbParagraphes)
        {
            HttpClient client = new HttpClient();


            client.DefaultRequestHeaders.Accept.Add(
                 new MediaTypeWithQualityHeaderValue("application/text"));
            String url = $"https://loripsum.net/api/{nbParagraphes}/short/plaintext";
            var response = client.GetAsync(url).Result;

            if (response.IsSuccessStatusCode)
            {
                string responseBody = response.Content.ReadAsStringAsync().Result;

                return responseBody;

            }
            else
            {
                throw new Exception("Erreur API : " + (int)response.StatusCode + " " + response.ReasonPhrase);
            }

        }

        public static void TesteSplit()
        {
            String phrase = "Il fait toujours beau à Toulon";
            var tab = phrase.Split(' ');
            String valeurs = "rue;avenue;boulevard;place";
            tab = valeurs.Split(';');
        }
    }
}
