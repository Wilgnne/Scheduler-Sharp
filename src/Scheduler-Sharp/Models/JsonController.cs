﻿using System;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using System.Collections.Generic;

using SchedulerSharp.GUI;
namespace SchedulerSharp.Models
{
    /// <summary>
    /// Ponte Json.
    /// Contem dos os metodos necessarios para criar e abrir jsons.
    /// </summary>
    public static class JsonController
    {
        /// <summary>
        /// Serializar uma lista.
        /// Metodo que serializa uma lista, a transformando em uma string json.
        /// </summary>
        /// <param name="list">Lista a ser serializada</param>
        public static string ListToJson<T> (List<T> list)
        {
            return JsonConvert.SerializeObject(list, Formatting.Indented);
        }

        /// <summary>
        /// Desserializar uma lista.
        /// Metodo que desserializa um json, o transformando em uma lista.
        /// </summary>
        /// <param name="json">String json a ser desserializada.</param>
        public static List<T> JsonToList<T> (string json)
        {
            List<T> l = null;
            try
            {
                l = JsonConvert.DeserializeObject<List<T>>(json);
            }
            catch (Exception exception)
            {
                GTKUtils.ShowDilog("Erro ao decodificar arquivo!", Gtk.MessageType.Error, exception.Message);
            }

            return l;
        }

        public static string ObjectToJson<T>(T obj)
        {
            return JsonConvert.SerializeObject(obj, Formatting.Indented);
        }

        public static bool JsonToObject<T> (string json, ref T obj)
        {
            try
            {
                obj = JsonConvert.DeserializeObject<T>(json);
                return true;
            }
            catch 
            {
                return false;
            }
        }

        /// <summary>
        /// Salva um json.
        /// Metodo que salva uma string em um arquivo.
        /// </summary>
        /// <param name="json">Conteudo a ser salvo.</param>
        /// <param name="path">Endereçõ do arquivo.</param>
        /// <returns>
        /// Retorna true se foi possivel salvar o arquivo e falso em caso de erro.
        /// </returns>
        public static bool SaveJson (string json, string path)
        {
            try
            {
                using (StreamWriter outputFile = new StreamWriter(path, false, Encoding.UTF8))
                {
                    outputFile.WriteLine(json);
                }
            }
            catch (IOException e) //Caso ocora um erro, mostrar uma mensagem
            {
                Console.WriteLine("Erro ao salvar o arquivo");
                Console.WriteLine(e.Message);
                GTKUtils.ShowDilog
                (   "Save error!",
                    Gtk.MessageType.Warning,
                    e.Message
                );
                return false;
            }
            return true;
        }

        /// <summary>
        /// Abrir um json.
        /// Metodo que abre um arquivo e retorna uma string correspondente ao seu conteudo.
        /// </summary>
        /// <param name="path">Endereçõ do arquivo.</param>
        /// <param name="json">Conteudo do arquivo.</param>
        /// <returns>
        /// Retorna true se foi possivel abrir o arquivo e falso em caso de erro.
        /// </returns>
        public static bool OpenJson (string path, ref string json)
        {
            try
            {   // Abrindo arquivo usando o stream reader.
                using (StreamReader sr = new StreamReader(path))
                {
                    // Lendo o arquivo e o salvando na string text
                    json = sr.ReadToEnd();
                }
            }
            catch (IOException e) //Caso ocora um erro, mostrar uma mensagem
            {
                Console.WriteLine("Erro ao abrir o arquivo");
                Console.WriteLine(e.Message);

                GTKUtils.ShowDilog
                (   "Open error!",
                    Gtk.MessageType.Warning,
                    e.Message
                );

                return false;
            }

            return true;
        }
    }
}
