using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace comando.Models
{
    public class profile
    {
        public int ID { get; set; }
        [Required]
        public String name { get; set; }
        [Required]
        public String lastname { get; set; }
        [Required]
        public String addrress { get; set; }
        [Required]
        public String phones { get; set; }
        [EmailAddress]
        public String email { get; set; }
        public int useid { get; set; }
    }

    public class user
    {
        public int ID { get; set; }
        [Required]
        public String name { get; set; }
        [Required]
        public String usernamne { get; set; }
        [Required]
        public String password { get; set; }
        public int rolid { get; set; }
        public int configid { get; set; }
        public Int16 isSA { get; set; }
        public Int16 status { get; set; }


    }

    public class role
    {
        public int ID { get; set; }
        [Required]
        public String name { get; set; }
        [Required]
        public Int16 status { get; set; }
    }

    public class component
    {
        public int ID { get; set; }
        [Required]
        public String name { get; set; }
        [Required]
        public String path { get; set; }
        [Required]
        public String description { get; set; }
    }

    public class level
    {
        public int ID { get; set; }
        [Required]
        public String name { get; set; }
    }

    public class AgentByUser
    {
        public int ID { get; set; }
        public int userid { get; set; }
        public int agentid { get; set; }
        public int levelid { get; set; }


    }

    public class permission
    {
        public int ID { get; set; }
        public int rolid { get; set; }
        public int moduleid { get; set; }
        public int actionid { get; set; }
    }

    public class module
    {
        public int ID { get; set; }
        [Required]
        public String name { get; set; }
        [Required]
        public String description { get; set; }
        [Required]
        public String path { get; set; }

        public int componetid { get; set; }
    }

    public class agent
    {
        public int ID { get; set; }
        [Required]
        public String name { get; set; }
    }

    public class action
    {
        public int ID { get; set; }
        [Required]
        public String name { get; set; }
        [Required]
        public String description { get; set; }
        [Required]
        public String path { get; set; }
        public int moduleid { get; set; }
    }

    public class modeloDbContext : DbContext
    {
        // public DbSet<persona> personas { get; set; }
        public DbSet<profile> profiles { get; set; }
        public DbSet<user> users { get; set; }
        public DbSet<role> roles { get; set; }
        public DbSet<component> components { get; set; }
        public DbSet<level> levels { get; set; }
        public DbSet<AgentByUser> AgentByUsers { get; set; }
        public DbSet<permission> permissions { get; set; }
        public DbSet<module> modules { get; set; }
        public DbSet<agent> agents { get; set; }
        public DbSet<action> actions { get; set; }
    }

}