using Autofac;
using Businnes.Abstract;
using Businnes.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businnes.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CustomerManager>().As<ICustomerService>().SingleInstance();
            builder.RegisterType<EfCustomerDal>().As<ICustomerDal>().SingleInstance();

            builder.RegisterType<CityManager>().As<ICityService>().SingleInstance();
            builder.RegisterType<EfCityDal>().As<ICityDal>().SingleInstance();

            builder.RegisterType<DistrictManager>().As<IDistrictService>().SingleInstance();
            builder.RegisterType<EfDistrictDal>().As<IDistrictDal>().SingleInstance();

            builder.RegisterType<HospitalManager>().As<IHospitalService>().SingleInstance();
            builder.RegisterType<EfHospitalDal>().As<IHospitalDal>().SingleInstance();

            builder.RegisterType<PolicyManager>().As<IPolicyService>().SingleInstance();
            builder.RegisterType<EfPolicyDal>().As<IPolicyDal>().SingleInstance();

            builder.RegisterType<CoverageManager>().As<ICoverageService>().SingleInstance();
            builder.RegisterType<EfCoverageDal>().As<ICoverageDal>().SingleInstance();

            builder.RegisterType<PolicyCoverageManager>().As<IPolicyCoverageService>().SingleInstance();
            builder.RegisterType<EfPolicyCoverageDal>().As<IPolicyCoverageDal>().SingleInstance();

            builder.RegisterType<PaymentManager>().As<IPaymentService>().SingleInstance();
            builder.RegisterType<EfPaymentDal>().As<IPaymentDal>().SingleInstance();
        }
    }
}
