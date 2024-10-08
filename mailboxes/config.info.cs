line0=Konfigurovatelné volby,11
wrap_width=Šířka pro zalomení poštovních zpráv,0,6
perpage=Počet zobrazených zpráv na jedné stránce,0,6
show_to=Zobrazit Komu: adresu v poštovních schránkách?,1,1-Ano,0-Ne
top_buttons=Zobrazit tlačítka nahoře pro,1,2-Složky i zprávy,1-Pouze složky,0-Nikdy
arrows=Zobrazit dolní šipky stránkovače pro,1,2-Složky i zprávy,1-Pouze složky,0-Nikdy
show_delall=Zobrazit tlačítko pro kompletní smazání poštovní schránky?,1,1-Ano,0-Ne
show_sent=Zobrazit počet zpráv ve složce s odeslanou poštou?,1,1-Ano,0-Ne
fwd_mode=Přeposlat zprávy s kvotací?,1,0-Ano,1-Ne
delete_warn=Ověřit si konfiguraci před mazáním?,10,y-Ano,n-Ne,Pro soubory složek větších než
view_html=Zobrazit tělo zprávy jako,4,0-Vždy jako běžný text,1-Je&#45;li to možné jako text&#44; jinak HTML,2-Je&#45;li to možné jako HTML&#44; jinak jako text,3-Konvertovat HTML do běžného textu
html_edit=Používat při psaní zprávy HTML editor?,1,2-Vždy,1-Při odpovědi na HTML mail,0-Nikdy
html_quote=Mód pro HTML kvótu,1,1-Zpráva pod &lt;hr&gt;,0-Zpráva uvnitř &lt;blockquote&gt;
log_read=Nahrát čtení zprávy do Logu Webmin akcí?,1,1-Ano,0-Ne
bcc_to=Skrytá kopie: odeslat zprávy adresátu,0
sig_file=Soubor se signaturou,10,*-Nic,.signature-~/.signature,Jiný soubor
show_body=Zobrazit v rámci seznamu náhled těla zprávy?,1,1-Ano,0-Ne
open_mode=Otevřít zprávy v,1,1-Novém okně,0-Tom samém okně
link_mode=Otevírat odkazy v,1,1-Novém okně,0-Tom samém okně
download=MIME typy příloh&#44; které budou vždy nahrány,9,20,4,\t
date_fmt=Formát data v seznamu mailů,1,auto-Locale based,dmy-DD/MM/YYYY,mdy-MM/DD/YYYY,ymd-YYYY/MM/DD
date_tz=Časová zóna při zobrazení data,3,Výchozí systémové
max_records=Maximální počet zobrazených uživatelů,0,6
show_size=Mód zobrazení uživatelů,1,0-Pouze jména uživatelů,1-Jména uživatelů a velikost,2-Všechny detaily
show_size_below=Jména uživatelů a velikost - Kde bude zobrazena velikost,1,0-napravo od jména,1-pod jménem
column_count=Počet sloupců se zobrazenými uživatelskými jmény,1,3-3,4-4,5-5,6-6,7-7,8-8,9-9
show_count=Zobrazit počet zpráv v Inboxu?,1,1-Ano,0-Ne
sort_mode=Třídit poštovní schránky podle,1,2-Velikosti,1-Jména,0-souboru s hesly (passwd)
show_mail=Zobrazit pouze uživatele s mailem?,1,1-Ano,0-Ne
size_mode=Zahrnout všechny složky s nějakou velikostí?,1,1-Ano,0-Ne (pouze první složku)
ignore_users=Ignorovat tyto uživatele (nezobrazovat),15,userIgnoreList
ignore_users_enabled=Stav seznamu pro ignorování,1,1-Zapnutý,0-Vypnutý
track_read=Označovat přečtenou/nepřečtenou poštu,1,1-Ano,0-Ne
show_unread=Zobrazit počet nepřečtených zpráv?,1,2-Ano,0-Ne
check_mod=Zkontrolovat změnu mailové schránky během mazání zprávy?,1,1-Ano,0-Ne
line3=Volby pro Spam,11
spam_buttons=Zobrazit tlačítka pro oznámení spamu pro,2,seznam-Poštovní schránky,mail-Zprávy
spam_del=Smazat spam při oznámení?,1,1-Ano,0-Ne
spam_report=Oznámit spam použitím,1,sa_learn-sa&#45;learn --spam,spamassassin-spamassasin -r,-Rozhodnout automaticky
line3.5=Volby pro Od: adresu,11
from_addr=Od: adresa užívaná pro ruční odeslání zprávy,3,Jméno uživatele poštovní schránky
webmin_from=Použitá Od: adresa v momentě&#44; kdy odesílá mail Webmin,3,Výchozí (webmin-noreply@<i>vášhost</i>)
from_virtualmin=Získat Od: adresu z Virtualminu?,1,1-Ano,0-Ne
from_dom=Doména užívaná v Od: adrese,3,Hostname systému
line1=Systémová konfigurace,11
mail_system=Nainstalovaný poštovní server,4,1-Sendmail,0-Postfix,2-Qmail,4-Qmail+LDAP,5-Qmail+VPopMail,3-Zjistit automaticky
send_mode=Odeslat zprávu pomocí,10,-Programu v poštovním serveru,SMTP serveru
no_crlf=Přidat návrat řádku ( \r ) na konci každého řádku?,1,0-Ano,1-Ne
smtp_user=Přihlašovací jméno pro SMTP mail server,3,Nic
smtp_pass=Heslo pro SMTP mail server,3,Nic
smtp_auth=Metoda SMTP autentikace,4,-Výchozí,Cram-MD5-Cram&#45;MD5,Digest-MD5-Digest&#45;MD5,Plain-Plain,Login-Login
auto=Automaticky detekovat umístění souborů s mailem?,1,1-Ano&#44; založeno na poštovním serveru,0-Ne&#44; použít níže uvedené nastavení ..
mail_dir=Adresář pro uživatelské soubory s poštou,3,Nic
mail_style=Styl adresáře se soubory s poštou,4,0-mail/username,1-mail/u/username,2-mail/u/us/username,3-mail/u/s/username
mail_file=Soubor se zprávami v domovském adresáři uživatele,3,Nic
mail_sub=Adresář pro zprávy v domovském adresáři uživatele,3,Nic
mail_usermin=Styl (pod)složek v domovském adresáři zobrazený v Userminu,3,Nic
mailbox_user=Konfigurace adresáře v domovském adresáři pro Usermin,3,Nic
line2=Uživatelská konfigurace,11
sync_create=Vytvořit poštovní schránku při vytvoření uživatele?,1,1-Ano,0-Ne
sync_modify=Přejmenovat poštovní schránku při přejmenování uživatele?,1,1-Ano,0-Ne
sync_delete=Smazat poštovní schránku při smazaní uživatele?,1,1-Ano,0-Ne
sync_perms=Práva pro nové poštovní schránky,0,4
line4=Volby VPOPMail,11
vpopmail_dir=Hlavní adresář pro VPOPMail,0
line5=Volby pro Qmail+LDAP,11
ldap_host=LDAP server,0
ldap_port=Port LDAP serveru,3,Výchozí
ldap_login=Přihlášení do LDAP serveru,0
ldap_pass=Heslo do LDAP serveru,0
ldap_base=Zdroj pro poštovní uživatele,0
