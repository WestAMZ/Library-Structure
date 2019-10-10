using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Authors.Commands.CreateAuthor
{
    class CreateAuthorCommand : IRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Nationality { get; set; }
    }
}
