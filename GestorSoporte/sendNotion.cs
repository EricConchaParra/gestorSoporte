﻿using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorSoporte
{
    internal class sendNotion
    {
        public static void grabaSoporte(string descripcion, string nota, string fantasiaCliente, string sucursal, string funcionario, int tiempo, string fecha, string cobrar, string horaInicio)
        {
            try {

                var obj = new
                {
                    parent = new
                    {
                        database_id = Seguridad.DesEncriptar(MySql.GetConfig().Rows[0]["notion_database"].ToString())
                },
                properties = new
                {
                    Descripción = new
                    {
                        title = new[]
                        {
                            new
                            {
                                type = "text",
                                text = new
                                {
                                    content = descripcion
                                }
                            }
                        }
                    },
                    Cliente = new
                    {
                        select = new
                        {
                            name = fantasiaCliente
                        }
                    },
                    Funcionario = new
                    {
                        select = new
                        {
                            name = funcionario
                        }
                    },

                    Minutos = new
                    {
                        number = tiempo
                    },

                    Cobrar = new
                    {
                        select = new
                        {
                            name = cobrar
                        }
                    },

                    Fecha = new
                    {
                        date = new
                        {
                            start = fecha
                        }
                    }
                },

                children = new[]
                {
                new{
                    @object = "block",
                    paragraph = new
                    {
                        rich_text = new[]
                        {
                            new
                            {
                                text = new
                                {
                                    content = "Inicio evento: " + horaInicio +" - Sucursal: " + sucursal + "\n\n" + nota
                                }
                            }
                        }
                    }
                }

                }
            };

            var data = JsonConvert.SerializeObject(obj, Formatting.Indented);

            RestClient client = new RestClient("https://api.notion.com");//Aqui va la Base URL

            var request = new RestRequest("/v1/pages", Method.Post);//Aquí va el EndPoint y el metodo 
            request.AddHeader("Notion-Version", "2022-06-28");
            request.AddHeader("Authorization", string.Format("Bearer {0}", Seguridad.DesEncriptar(MySql.GetConfig().Rows[0]["notion_key"].ToString())));
            request.AddBody(data);

            var response = client.Execute(request);

            var error = response.ErrorMessage; //Si viene vacío, significa que se envió bien

            }
            catch (Exception ex)
            {
                alerta.error("Error", ex.ToString());
            }


        }
    }
}
