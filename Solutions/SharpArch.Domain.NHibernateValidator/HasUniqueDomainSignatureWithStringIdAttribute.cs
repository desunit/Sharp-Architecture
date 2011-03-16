namespace SharpArch.Domain.NHibernateValidator
{
    using System;

    using NHibernate.Validator.Engine;

    [AttributeUsage(AttributeTargets.Class)]
    [ValidatorClass(typeof(HasUniqueDomainSignatureWithStringIdValidator))]
    public class HasUniqueDomainSignatureWithStringIdAttribute : Attribute, IRuleArgs
    {
        private string message = "Provided values matched an existing, duplicate entity";

        public string Message
        {
            get
            {
                return this.message;
            }

            set
            {
                this.message = value;
            }
        }
    }
}