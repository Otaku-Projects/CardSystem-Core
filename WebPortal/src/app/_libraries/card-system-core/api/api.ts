export * from './authentication.service';
import { AuthenticationService } from './authentication.service';
export * from './employeeEntity.service';
import { EmployeeEntityService } from './employeeEntity.service';
export * from './systemUserEntity.service';
import { SystemUserEntityService } from './systemUserEntity.service';
export * from './weatherForecast.service';
import { WeatherForecastService } from './weatherForecast.service';
export const APIS = [AuthenticationService, EmployeeEntityService, SystemUserEntityService, WeatherForecastService];
