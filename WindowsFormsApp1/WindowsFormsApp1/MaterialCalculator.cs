using System;

namespace PartnerManagementSystem
{
    public static class MaterialCalculator
    {
        
        
        public static int CalculateMaterialRequired(
            int serviceTypeId,
            int materialTypeId,
            int serviceCount,
            params double[] serviceParameters)
        {
            try
            {
               
                if (serviceTypeId <= 0 || materialTypeId <= 0 || serviceCount <= 0)
                    return -1;

                if (serviceParameters == null || serviceParameters.Length == 0)
                    return -1;

                foreach (double param in serviceParameters)
                {
                    if (param <= 0)
                        return -1;
                }

                
                double serviceTypeCoefficient = GetServiceTypeCoefficient(serviceTypeId);
                double materialOverheadPercentage = GetMaterialOverheadPercentage(materialTypeId);

            
                double materialPerService = 1.0;
                foreach (double param in serviceParameters)
                {
                    materialPerService *= param;
                }

                materialPerService *= serviceTypeCoefficient;

               
                double totalMaterial = materialPerService * serviceCount;

              
                totalMaterial *= (1 + materialOverheadPercentage);

              
                return (int)Math.Ceiling(totalMaterial);
            }
            catch
            {
                return -1;
            }
        }

        private static double GetServiceTypeCoefficient(int serviceTypeId)
        {
            
            switch (serviceTypeId)
            {
                case 1:
                    return 1.0;   
                case 2:
                    return 2.5;   
                case 3:
                    return 3.0;  
                case 4:
                    return 1.8;   
                case 5:
                    return 0.5;   
                default:
                    return 1.0;   
            }
        }

        private static double GetMaterialOverheadPercentage(int materialTypeId)
        {
            
            switch (materialTypeId)
            {
                case 1:
                    return 0.05;  
                case 2:
                    return 0.08;  
                case 3:
                    return 0.1;   
                case 4:
                    return 0.03;  
                case 5:
                    return 0.07;  
                case 6:
                    return 0.02;  
                default:
                    return 0.05;  
            }
        }
    }
}