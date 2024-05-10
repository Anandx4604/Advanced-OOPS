using System;
using System.Collections.Generic;
namespace MetroCardManagement
{
    public static class Search
    {
        public static UserDetails CardNumberSearch(string searchElement)
        {
            CustomList<UserDetails> userDetailsList = Operations.userDetailsList;
            int left = 0;
            int right = userDetailsList.Count - 1;

            while (left <= right)
            {
                int middle = (left + right) / 2;

                if (userDetailsList[middle].CardNumber == searchElement)
                {
                    return userDetailsList[middle];
                }

                else if (string.Compare(userDetailsList[middle].CardNumber, searchElement) < 0)
                {
                    left = middle + 1;
                }

                else
                {
                    right = middle - 1;

                }
            }
            return null;
        }

         public static TravelDetails TravelDetailsSearch(string searchElement)
        {
            CustomList<TravelDetails> travelDetailsList = Operations.travelDetailsList;
            int left = 0;
            int right = travelDetailsList.Count - 1;

            while (left <= right)
            {
                int middle = (left + right) / 2;

                if (travelDetailsList[middle].CardNumber == searchElement)
                {
                    return travelDetailsList[middle];
                }

                else if (string.Compare(travelDetailsList[middle].CardNumber, searchElement) < 0)
                {
                    left = middle + 1;
                }

                else
                {
                    right = middle - 1;

                }
            }
            return null;
        }

    }
}