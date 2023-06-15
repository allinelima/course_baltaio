using System.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using course_baltaio.NotificationContext;

namespace course_baltaio.SharedContext;

public abstract class Base : Notifiable
{
    public Base()
    {
         Id = Guid.NewGuid();
    }

    public Guid Id { get; set; }
}