using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using DataAccess.Abstract;
using DataAccess.Concrete;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UserManager>().As<IUserService>().SingleInstance();
            builder.RegisterType<EfUserDal>().As<IUserDal>().SingleInstance();
            
            builder.RegisterType<OperationClaimManager>().As<IOperationClaimService>().SingleInstance();
            builder.RegisterType<EfUserOperationClaimDal>().As<IUserOperationClaimDal>().SingleInstance();
            
            builder.RegisterType<UserOperationClaimManager>().As<IUserOperationClaimService>().SingleInstance();
            builder.RegisterType<EfOperationClaimDal>().As<IOperationClaimDal>().SingleInstance();

            builder.RegisterType<RecordManager>().As<IRecordService>().SingleInstance();
            builder.RegisterType<EfRecordDal>().As<IRecordDal>().SingleInstance();

            builder.RegisterType<PartManager>().As<IPartService>().SingleInstance();
            builder.RegisterType<EfPartStatusDal>().As<IPartStatusDal>().SingleInstance();

            builder.RegisterType<MaintenanceTypeManager>().As<IMaintenanceTypeService>().SingleInstance();
            builder.RegisterType<EfMaintenanceTypeDal>().As<IMaintenanceTypeDal>().SingleInstance();
            
            builder.RegisterType<BaseManager>().As<IBaseService>().SingleInstance();
            builder.RegisterType<EfBaseDal>().As<IBaseDal>().SingleInstance();

            builder.RegisterType<PlaneManager>().As<IPlaneService>().SingleInstance();
            builder.RegisterType<EfPlaneDal>().As<IPlaneDal>().SingleInstance();

            builder.RegisterType<AuthManager>().As<IAuthService>().SingleInstance();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}