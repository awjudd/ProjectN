﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectN.Application.Features.Colleges.Queries.GetCollegesList
{
    public class GetCollegesListQuery : IRequest<List<CollegeListVm>>
    {
    }
}
