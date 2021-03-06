﻿using System;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using System.Collections.Generic;

using SchedulerSharp.Models;

namespace SchedulerSharp.GUI.PlotInterface
{
    public partial class PlotInterface
    {
        IntervalBarSeries intervalBarSeries;

        /// <summary>
        /// Inicializar dados de comparação.
        /// </summary>
        /// <param name="fcfsTimes">Fcfs times.</param>
        /// <param name="sjfTimes">Sjf times.</param>
        /// <param name="rrTimes">Rr times.</param>
        /// <param name="text">Text.</param>
        private void SetUtilizationData (List<double> fcfsTimes, List<double> sjfTimes, List<double> rrTimes, List<string> text)
        {
            ColumnSeries FCFSTime = new ColumnSeries
            {
                Title = "FCFS",
                FillColor = OxyColors.DarkTurquoise,
            };
            ColumnSeries SJFTime = new ColumnSeries
            {
                Title = "SJF",
                FillColor = OxyColors.Tomato,
            };
            ColumnSeries RRTime = new ColumnSeries
            {
                Title = "RR",
                FillColor = OxyColors.Orange,
            };

            for (int index = 0; index < fcfsTimes.Count; index++)
            {
                FCFSTime.Items.Add(CreateColumnItem(fcfsTimes[index]));
                SJFTime.Items.Add(CreateColumnItem(sjfTimes[index]));
                RRTime.Items.Add(CreateColumnItem(rrTimes[index]));
            }

            model.Series.Add(FCFSTime);
            model.Series.Add(SJFTime);
            model.Series.Add(RRTime);
        }

        /// <summary>
        /// Criar itens de coluna.
        /// </summary>
        /// <returns>The column item.</returns>
        /// <param name="value">Value.</param>
        public ColumnItem CreateColumnItem(double value)
        {
            return new ColumnItem
            {
                Value = value,
                //Title = string.Format("{0:C3} Clock's", value]),
                //CategoryIndex = index,
                //Color = color
            };
        }

        public static int StringToInt(string str)
        {
            char[] vs = str.ToCharArray();
            int acc = 0;
            for (int i = 0; i < vs.Length; i++)
            {
                acc += Convert.ToInt32(Convert.ToByte(vs[i]));
            }
            return acc;
        }

        /// <summary>
        /// Inicializar dados escalonados.
        /// </summary>
        /// <param name="processes">Processes.</param>
        private void SetUtilizationData(List<PlotableProcess> processes)
        {
            for (int index = 0; index < processes.Count; index++)
            {
                PlotableProcess process = processes[index];
                IntervalBarItem item = new IntervalBarItem
                {
                    Start = process.ExecTime - 0.5f,
                    End = process.ExecTime + 0.5f,
                    CategoryIndex = YLabel.IndexOf(process.name),
                    //Title = process.Name,
                    Color = process.attColor,
                };
                intervalBarSeries.Items.Add(item);
            }
        }

        /// <summary>
        /// Inicializar dados ha escalonar.
        /// </summary>
        /// <param name="processes">Processes.</param>
        private void SetUtilizationData(List<Process> processes)
        {
            for (int index = 0; index < processes.Count; index++)
            {
                Process process = processes[index];
                IntervalBarItem item = new IntervalBarItem
                {
                    Start = process.arrivalTime,
                    End = process.arrivalTime + process.runtime,
                    CategoryIndex = index,
                    //Title = process.Name,
                    Color = ((PlotableProcess)process).attColor,
                };
                intervalBarSeries.Items.Add(item);
            }
        }

        /// <summary>
        /// Inicializar modelo.
        /// </summary>
        /// <param name="yLabels">Y labels.</param>
        /// <param name="Title">Title.</param>
        /// <param name="xTitle">X title.</param>
        /// <param name="yTitle">Y title.</param>
        /// <param name="invert">If set to <c>true</c> invert.</param>
        public void InitializeAModel(List<string> yLabels, string Title, string xTitle = "Clock's", string yTitle = "Processos", bool invert = false, bool isAnim = false)
        {
            model = new PlotModel
            {
                LegendOrientation = LegendOrientation.Horizontal,
                LegendPosition = LegendPosition.BottomCenter,
                LegendPlacement = LegendPlacement.Outside,
                LegendBorderThickness = 0,
                Title = Title
            };

            LinearAxis xAxis = new LinearAxis()
            {
                Title = xTitle,
                Position = AxisPosition.Bottom,
            };

            // Define o eixo Y
            CategoryAxis yAxis = new CategoryAxis
            {
                Title = yTitle,
                Position = AxisPosition.Left,
            };
            yAxis.Labels.AddRange(yLabels);

            if (invert)
            {
                xAxis.Position = AxisPosition.Left;
                yAxis.Position = AxisPosition.Bottom;
            }

            if(isAnim)
            {
                xAxis.IsZoomEnabled = false;
                xAxis.IsPanEnabled = false;

                yAxis.IsZoomEnabled = false;
                yAxis.IsPanEnabled = false;
            }

            // Adiciona ao eixo do plotModel
            model.Axes.Add(xAxis);
            // Adiciona ao eixo do plotModel
            model.Axes.Add(yAxis);
        }

        public void InitializeAIntervalBarSeries(bool isAnim = false)
        {
            intervalBarSeries = new IntervalBarSeries
            {
                LabelMargin = 0,
                BarWidth = 0.75,
                StrokeColor = OxyColors.Transparent,
            };
            intervalBarSeries.Selectable = !isAnim;     
        }

        public BarSeries InitializeABarSeries(BarSeries bar)
        {
            bar = new BarSeries
            {
                LabelMargin = 0,
            };
            return bar;
        }
    }
}
