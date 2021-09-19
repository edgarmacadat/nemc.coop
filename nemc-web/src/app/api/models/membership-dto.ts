/* tslint:disable */
import { AddressDTO } from './address-dto';
import { PersonalDataDTO } from './personal-data-dto';
export interface MembershipDTO {
  addresses?: Array<AddressDTO>;
  createdBy?: number;
  createdDate?: string;
  isActive?: boolean;
  isOfficer?: boolean;
  lastUpdatedBy?: number;
  lastUpdatedDate?: string;
  membershipID?: number;
  membershipNumber?: string;
  personalData?: PersonalDataDTO;
  shareMonthlyDeduction?: number;
  subscribedAmount?: number;
}
