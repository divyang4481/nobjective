::
:: Created by Grishul Eugeny
::
:: License see in License.txt
::

SET SSHUSER=Jack
SET SSHPASS=yoyoyo
SET SSHTERM="C:\Program Files (x86)\Bitvise Tunnelier\sexec.exe" %SSHUSER%@%SSHHOST% -pw=%SSHPASS% -cmd=

SET SMBUSER=NObjectiveUser
SET SMBPASS=yoyoyo
SET SMBHOST=192.168.1.3

%SSHTERM%"mkdir NObjective; mount -t smbfs //%SMBUSER%:%SMBPASS%@%SMBHOST%/NObjective NObjective"