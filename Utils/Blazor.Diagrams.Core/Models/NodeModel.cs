﻿using Blazor.Diagrams.Core.Models.Base;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Blazor.Diagrams.Core.Models
{
    public class NodeModel : SelectableModel
    {
        private Size? _size;
        private readonly List<PortModel> _ports = new List<PortModel>();

        public NodeModel(Point? position = null, RenderLayer layer = RenderLayer.HTML)
        {
            Position = position ?? Point.Zero;
            Layer = layer;
        }

        public NodeModel(string id, Point? position = null, RenderLayer layer = RenderLayer.HTML) : base(id)
        {
            Position = position ?? Point.Zero;
            Layer = layer;
        }

        public Size? Size
        {
            get => _size;
            set
            {
                _size = value;
                Refresh();
            }
        }

        public string Title { get; private set; }
        public Point Position { get; private set; }
        public RenderLayer Layer { get; }
        public ReadOnlyCollection<PortModel> Ports => _ports.AsReadOnly();
        public IEnumerable<LinkModel> AllLinks => Ports.SelectMany(p => p.Links);
        public Group? Group { get; internal set; }

        public PortModel AddPort(PortAlignment alignment = PortAlignment.BOTTOM)
        {
            var port = new PortModel(this, alignment, Position);
            _ports.Add(port);
            return port;
        }

        public bool RemovePort(PortModel port) => _ports.Remove(port);

        public PortModel GetPort(PortAlignment alignment) => Ports.FirstOrDefault(p => p.Alignment == alignment);

        public void SetTitle(string title)
        {
            Title = title;
        }

        public void SetPosition(double x, double y)
        {
            Position = new Point(x, y);
            foreach (var port in _ports)
            {
                port.Position = new Point(Position.X + port.Offset.X, Position.Y + port.Offset.Y);
            }
        }

        public void RefreshAll()
        {
            Refresh();
            _ports.ForEach(p => p.RefreshAll());
        }
    }
}