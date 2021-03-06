﻿using Gtk;
using System;
using System.Collections.Generic;

using SchedulerSharp.Models;
using SchedulerSharp.GUI;

namespace SchedulerSharp.GUI.CreationInterface
{
    public partial class CreationController
    {
        public List<ComboBox> historicBoxs;
        public CreationView creationView;

        /// <summary>
        /// Inicializa uma nova instancia do <see cref="T:SchedulerSharp.GUI.CreationController"/> class.
        /// Classe responsavel por todo o controle da area de criação
        /// </summary>
        /// <param name="conteinerCreationView">Conteiner de criação.</param>
        /// <param name="comboBoxes">ComboBoxes de historico de arquivos carregados.</param>
        public CreationController(List<ComboBox> comboBoxes,Container conteinerCreationView)
        {
            historicBoxs = comboBoxes;

            creationView = new CreationView(conteinerCreationView);
            HistoricInitialize();
        }

        /// <summary>
        /// Evento do botão Salvar
        /// </summary>
        public void SaveEvent (VoidDelegade callback)
        {
            string json = JsonController.ListToJson(GetItens());
            if (string.IsNullOrEmpty(historicBuffer) == false)
            {
                if (GetItens().Count > 0 && JsonController.SaveJson(json, historicBuffer))
                {
                    EditButtonEvent(historicBuffer, callback);
                    return;
                }
            }
            SaveAsEvent(callback);
        }

        /// <summary>
        /// Evento Salvar Como...
        /// </summary>
        /// <param name="path">Diretorio do arquivo.</param>
        public void SaveAsEvent (VoidDelegade callback)
        {
            if (GetItens().Count > 0)
            {
                if (GTKUtils.ShowFileChooser(out string path, ".prb", "Salvar como..", "Salvar"))
                {
                    string json = JsonController.ListToJson(GetItens());
                    if (JsonController.SaveJson(json, path))
                    {
                        Console.WriteLine(path);
                        EditButtonEvent(path, callback);
                    }
                }
            }
            else
            {
                GTKUtils.ShowDilog("Não há dados a serem salvos!", MessageType.Warning, "Use a aba de Criação para gerar e editar processos!");
            }
        }

        /// <summary>
        /// Evento do botão Editar.
        /// </summary>
        /// <param name="path">Endereçõ do novo arquivo a ser editado</param>
        public bool EditButtonEvent(string path, VoidDelegade callback)
        {
            string json = null;
            if (JsonController.OpenJson(path, ref json))
            {
                Console.WriteLine("{0} existe", path);
                creationView.LoadItens(JsonController.JsonToList<Process>(json));
                UpdateAllHistoric(path);
                callback();
                return true;
            }

            Console.WriteLine("{0} nao existe", path);
            historicStrings.Remove(path);
            json = JsonController.ListToJson(historicStrings);
            JsonController.SaveJson(json, historicPath);
            ClearComboBox();
            return false;
        }

        private void ClearComboBox()
        {
            foreach (ComboBox box in historicBoxs)
            {
                box.Active = -1;
            }
            historicBuffer = null;
        }

        public void NewEvent()
        {
            creationView.LoadItens(new List<Process>());
            ClearComboBox();
        }

        /// <summary>
        /// Evento do botão de Adicionar item
        /// </summary>
        public void AddCreationEvent() => creationView.AddNewRamdomItem();

        /// <summary>
        /// Evento do botão de remover o item selecionado
        /// </summary>
        public void RemoveCreationEvent() => creationView.RemoveSelectedItem();

        /// <summary>
        /// Obter itens criados
        /// </summary>
        /// <returns>Os itens criandos</returns>
        public List<Process> GetItens() => creationView.Items;

        /// <summary>
        /// Ao Alterar o diretorio
        /// </summary>
        public bool OnChangeDirEntry(ComboBox sender, VoidDelegade callback)
        {
            Console.WriteLine("Chamada OnChangeDir: {0}", sender.ActiveText);
            if (historicBuffer != sender.ActiveText &&
                string.IsNullOrEmpty(sender.ActiveText) == false)
            {
                return EditButtonEvent(sender.ActiveText, callback);
            }
            return false;
        }
    }
}
