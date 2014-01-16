# DAT File Structure

The DAT files are used to store flight characteristics and metadata on aircraft used by YSFlight. They are stored in a human readable format and allow comments so are very easy to understand.

For each entry there is an identifier for the command and a number of parameters, separated by spaces. Below is a list of commands, what it does, the parameters accepted, and an example.

## List of commands

<table>
	<tr>
		<th>
			Command
		</th>
		<th>
		</th>
		<th>
			Parameters
		</th>
		<th>
			Example
		</th>
	</tr>
	<tr>
		<td>
			IDENTIFY
		</td>
		<td>
			Specifiers the name of the aircraft.
		</td>
		<td>
			Name of aircraft, enclosed in double quotes.
		</td>
		<td>
			<pre><code>IDENTIFY "A6M5_ZERO"</code></pre>
		</td>
	</tr>
	<tr>
		<td>
			SUBSTNAME
		</td>
		<td>
			Unknown, name of aircraft.
		</td>
		<td>
			Name of aircraft, enclosed in double quotes; unsure if used internally.
		</td>
		<td>
			<pre><code>SUBSTNAM "A6M5_ZERO"</code></pre>
		</td>
	</tr>
	<tr>
		<td>
			CATEGORY
		</td>
		<td>
			Category of aircraft, used on aircraft list.
		</td>
		<td>
			Category of aircraft.
		</td>
		<td>
			<pre><code>CATEGORY WW2FIGHTER</code></pre>
		</td>
	</tr>
	<tr>
		<td>
			AIRCLASS
		</td>
		<td>
			Class of aircraft; unsure if used internally.
		</td>
		<td>
			Class of aircraft.
		</td>
		<td>
			<pre><code>AIRCLASS HELICOPTER</code></pre>
		</td>
	</tr>
	<tr class="space">
		<th colspan="4">
			Afterburner
		</th>
	</tr>
	<tr>
		<td>
			AFTERBURNER
		</td>
		<td>
			Whether or not the aircraft has an afterburner.
		</td>
		<td>
			TRUE or FALSE.
		</td>
		<td>
			<pre><code>AFTBURNR FALSE</code></pre>
		</td>
	</tr>
	<tr>
		<td>
			THRAFTBN
		</td>
		<td>
			Thrust provided by afterburner.
		</td>
		<td>
			Thrust, as a mass unit.
		</td>
		<td>
			<pre><code>THRAFTBN  5.4t</code></pre>
		</td>
	</tr>
	<tr>
		<td>
			FUELABRN
		</td>
		<td>
			Fuel used when afterburner is operating.
		</td>
		<td>
			Mass of fuel used, as a mass unit.
		</td>
		<td>
			<pre><code>FUELABRN 7.2kg</code></pre>
		</td>
	<tr class="space">
		<th colspan="4">
			Propeller
		</th>
	</tr>
	<tr>
		<td>
			PROPELLR
		</td>
		<td>
			Power provided by a propellor engine.
		</td>
		<td>
			Power in horsepower, followed by HP.
		</td>
		<td>
			<pre><code>PROPELLR 1130HP</code></pre>
		</td>
	</tr>
	<tr>
		<td>
			PROPEFCY
		</td>
		<td>
			Efficiency of propellor.
		</td>
		<td>
			Efficiency as a decimal between 0 and 1.
		</td>
		<td>
			<pre><code>PROPEFCY 0.65</code></pre>
		</td>
	</tr>
	<tr>
		<td>
			PROPVMIN
		</td>
		<td>
			Minimum speed for T=P/V to become valid; unknown.
		</td>
		<td>
			Speed unit.
		</td>
		<td>
			<pre><code>PROPVMIN 20m/s</pre></code>
		</td>
	</tr>
	<tr>
		<td>
			FUELMILI
		</td>
		<td>
			Fuel used when propeller is operating.
		</td>
		<td>
			Mass of fuel used, as a mass unit.
		</td>
		<td>
			<pre><code>FUELMILI 3.6kg</code></pre>
		</td>
	</tr>
	<tr class="space">
		<th colspan="4">
			Jet Engine
		</th>
	</tr>
	<tr>
		<td>
			THRMILIT
		</td>
		<td>
			Thrust provided by jet engine.
		</td>
		<td>
			Thrust, as a mass unit.
		</td>
		<td>
			<pre><code>THRMILIT 5.4t</code></pre>
		</td>
	</tr>
	<tr>
		<td>
			FUELMILI
		</td>
		<td>
			Fuel used when jet engine is operating.
		</td>
		<td>
			Mass of fuel used, as a mass unit.
		</td>
		<td>
			<pre><code>FUELMILI 3.6kg</code></pre>
		</td>
	</tr>
	<tr class="space">
		<th colspan="4">
			Mass
		</th>
	</tr>
	<tr>
		<td>
			WEIGHCLN
		</td>
		<td>
			Mass of aircraft when unloaded.
		</td>
		<td>
			Mass unit.
		</td>
		<td>
			<pre><code>WEIGHCLN 9.8t</code></pre>
		</td>
	</tr>
	<tr>
		<td>
			WEIGFUEL
		</td>
		<td>
			Mass of fuel.
		</td>
		<td>
			Mass unit.
		</td>
		<td>
			<pre><code>WEIGFUEL 5.0t</code></pre>
		</td>
	</tr>
	<tr>
		<td>
			WEIGLOAD
		</td>
		<td>
			Mass of payload.
		</td>
		<td>
			Mass unit.
		</td>
		<td>
			<pre><code>WEIGLOAD 5.0t</code></pre>
		</td>
	</tr>
	<tr class="space">
		<th colspan="3">
			Positions
		</th>
	</tr>
	<tr>
		<td>
			COCKPITP
		</td>
		<td>
			Cockpit position.
		</td>
		<td>
			Position triplet.
		</td>
		<td>
			<pre><code>COCKPITP 0.0m 1.4m 3.70m</code></pre>
		</td>
	</tr>
	<tr>
		<td>
			LEFTGEAR
		</td>
		<td>
			Left wheel position.
		</td>
		<td>
			Position triplet.
		</td>
		<td>
			<pre><code>LEFTGEAR -1.3m -1.55m -3.20m</code></pre>
		</td>
	</tr>
	<tr>
		<td>
			RIGHGEAR
		</td>
		<td>
			Right wheel position.
		</td>
		<td>
			Position triplet.
		</td>
		<td>
			<pre><code>RIGHGEAR 1.3m -1.55m -3.20m</code></pre>
		</td>
	</tr>
	<tr>
		<td>
			WHELGEAR
		</td>
		<td>
			Centre wheel position.
		</td>
		<td>
			Position triplet.
		</td>
		<td>
			<pre><code>WHELGEAR 0.0m -1.55m 2.85m</code></pre>
		</td>
	</tr>
	<tr>
		<td>
			ARESTER
		</td>
		<td>
			Arrester position.
		</td>
		<td>
			Position triplet.
		</td>
		<td>
			<pre><code>ARRESTER 0.0m -1.34m -7.98m</code></pre>
		</td>
	</tr>
	<tr>
		<td>
			SMOKEGEN
		</td>
		<td>
			Smoke generator position.
		</td>
		<td>
			Position triplet.
		</td>
		<td>
			<pre><code>SMOKEGEN -0.3m -0.35m -7.75m</code></pre>
		</td>
	</tr>
	<tr>
		<td>
			VAPORPO0
		</td>
		<td>
			Vapour position, when wings swept back or no variable geometry wing.
		</td>
		<td>
			Position triplet.
		</td>
		<td>
			<pre><code>VAPORPO0 5.7m 0.15m -4.40m</code></pre>
		</td>
	</tr>
	<tr>
		<td>
			VAPORPO1
		</td>
		<td>
			Vapour position, when wings spread.
		</td>
		<td>
			Position triplet.
		</td>
		<td>
			<pre><code>VAPORPO1 5.7m 0.15m -4.40m</code></pre>
		</td>
	</tr>
	<tr class="space">
		<th colspan="4">
			Flight Handling
		</th>
	</tr>
	<tr>
		<td>
			CRITAOAP
		</td>
		<td>
			Critical positive angle of attack.
		</td>
		<td>
			Angle, followed by deg.
		</td>
		<td>
			<pre><code>CRITAOAP 22deg</code></pre>
		</td>
	</tr>
	<tr>
		<td>
			CRITAOAM
		</td>
		<td>
			Critical negative angle of attack.
		</td>
		<td>
			Angle, followed by deg.
		</td>
		<td>
			<pre><code>CRITAOAM -15deg</code></pre>
		</td>
	</tr>
	<tr>
		<td>
			CRITSPED
		</td>
		<td>
			Critical speed.
		</td>
		<td>
			Speed unit.
		</td>
		<td>
			<pre><code>CRITSPED 0.9MACH</code></pre>
		</td>
	</tr>
	<tr>
		<td>
			MAXSPEED
		</td>
		<td>
			Maximum speed.
		</td>
		<td>
			Speed unit.
		</td>
		<td>
			<pre><code>MAXSPEED 2.0MACH</code></pre>
		</td>
	</tr>
	<tr>
		<td>
			HASSPOIL
		</td>
		<td>
			Whether or not the aircraft has a spoiler.
		</td>
		<td>
			TRUE or FALSE.
		</td>
		<td>
			<pre><code>HASSPOIL TRUE</code></pre>
		</td>
	</tr>
	<tr>
		<td>
			RETRGEAR
		</td>
		<td>
			Whether or not the aircraft has a retractable landing gear.
		</td>
		<td>
			TRUE or FALSE.
		</td>
		<td>
			<pre><code>RETRGEAR TRUE</code></pre>
		</td>
	</tr>
	<tr>
		<td>
			VARGEOMW
		</td>
		<td>
			Whether or not the aircraft has a variable geometry wing.
		</td>
		<td>
			TRUE or FALSE.
		</td>
		<td>
			<pre><code>VARGEOMW FALSE</code></pre>
		</td>
	</tr>
	<tr>
		<td>
			CLVARGEO
		</td>
		<td>
			Effect of variable geometry wing on the coefficient of lift (Cl), i.e. Cl = Cl * value.
		</td>
		<td>
			Decimal value.
		</td>
		<td>
			<pre><code>CLVARGEO 0.0</code></pre>
		</td>
	</tr>
	<tr>
		<td>
			CDVARGEO
		</td>
		<td>
			Effect of variable geometry wing on the coefficient of drag (Cd), i.e. Cd = Cd * value.
		</td>
		<td>
			Decimal value.
		</td>
		<td>
			<pre><code>CDVARGEO 0.0</code></pre>
		</td>
	</tr>
	<tr>
		<td>
			CLBYFLAP
		</td>
		<td>
			Effect of flap on the coefficient of lift (Cl), i.e. Cl = Cl * value.
		</td>
		<td>
			Decimal value.
		</td>
		<td>
			<pre><code>CLBYFLAP 0.1</code></pre>
		</td>
	</tr>
	<tr>
		<td>
			CDBYFLAP
		</td>
		<td>
			Effect of flap on the coefficient of drag (Cd), i.e. Cd = Cd * value.
		</td>
		<td>
			Decimal value.
		</td>
		<td>
			<pre><code>CDBYFLAP 0.2</code></pre>
		</td>
	</tr>
	<tr>
		<td>
			CDBYGEAR
		</td>
		<td>
			Effect of gear on the coefficient of drag (Cd), i.e. Cd = Cd * value.
		</td>
		<td>
			Decimal value.
		</td>
		<td>
			<pre><code>CDBYGEAR 0.5</code></pre>
		</td>
	</tr>
	<tr>
		<td>
			CDSPOILR
		</td>
		<td>
			Effect of spoiler on the coefficient of drag (Cd), i.e. Cd = Cd * value.
		</td>
		<td>
			Decimal value.
		</td>
		<td>
			<pre><code>CDSPOILR 2.0</code></pre>
		</td>
	</tr>
	<tr>
		<td>
			WINGAREA
		</td>
		<td>
			Wing area, in meters squared.
		</td>
		<td>
			Area, followed by m^2.
		</td>
		<td>
			<pre><code>WINGAREA 28m^2</code></pre>
		</td>
	</tr>
	<tr>
		<td>
			MXIPTAOA
		</td>
		<td>
			Maximum input angle of attack.
		</td>
		<td>
			Degrees, followed by deg.
		</td>
		<td>
			<pre><code>MXIPTAOA 23.0deg</code></pre>
		</td>
	</tr>
	<tr>
		<td>
			MXIPTSSA
		</td>
		<td>
			Maximum input Side Slip Angle (yaw angle).
		</td>
		<td>
			Degrees, followed by deg.
		</td>
		<td>
			<pre><code>MXIPTSSA 5.0deg</code></pre>
		</td>
	</tr>
	<tr>
		<td>
			MXIPTROL
		</td>
		<td>
			Maximum input angle of roll.
		</td>
		<td>
			Degrees, followed by deg.
		</td>
		<td>
			<pre><code>MXIPTROL 360.0deg</code></pre>
		</td>
	</tr>
	<tr>
		<td>
			MANESPD1
		</td>
		<td>
			Minimum speed at which the aircraft is maneuverable.
		</td>
		<td>
			Speed unit.
		</td>
		<td>
			<pre><code>MANESPD1 40kt</code></pre>
		</td>
	</tr>
	<tr>
		<td>
			MANESPD2
		</td>
		<td>
			Minimum speed at which the aircraft is fully maneuverable.
		</td>
		<td>
			Speed unit.
		</td>
		<td>
			<pre><code>MANESPD2 80kt</code></pre>
		</td>
	</tr>
	<tr>
		<td>
			CPITMANE
		</td>
		<td>
			Pitch maneuverability constant.
		</td>
		<td>
			Decimal value.
		</td>
		<td>
			<pre><code>CPITMANE 10.0</code></pre>
		</td>
	</tr>
	<tr>
		<td>
			CPITSTAB
		</td>
		<td>
			Pitch stability constant.
		</td>
		<td>
			Decimal value.
		</td>
		<td>
			<pre><code>CPITSTAB 2.0</code></pre>
		</td>
	</tr>
	<tr>
		<td>
			CYAWMANE
		</td>
		<td>
			Yaw maneuverability constant.
		</td>
		<td>
			Decimal value.
		</td>
		<td>
			<pre><code>CYAWMANE 5.0</code></pre>
		</td>
	</tr>
	<tr>
		<td>
			CYAWSTAB
		</td>
		<td>
			Yaw stability constant.
		</td>
		<td>
			Decimal value.
		</td>
		<td>
			<pre><code>CYAWSTAB 3.0</code></pre>
		</td>
	</tr>
	<tr>
		<td>
			CROLLMAN
		</td>
		<td>
			Roll maneuverability constant.
		</td>
		<td>
			Decimal value.
		</td>
		<td>
			<pre><code>CROLLMAN 3.0</code></pre>
		</td>
	</tr>
	<tr>
		<td>
			REFVCRUS
		</td>
		<td>
			Cruising speed.
		</td>
		<td>
			Speed unit.
		</td>
		<td>
			<pre><code>REFVCRUS 0.9MACH</code></pre>
		</td>
	</tr>
	<tr>
		<td>
			REFACRUS 
		</td>
		<td>
			Cruising altitude.
		</td>
		<td>
			Height unit.
		</td>
		<td>
			<pre><code>REFACRUS 20000ft</code></pre>
		</td>
	</tr>
	<tr>
		<td>
			REFTCRUS
		</td>
		<td>
			Cruising throttle setting.
		</td>
		<td>
			Decimal, between 0 and 1.
		</td>
		<td>
			<pre><code>REFTCRUS 0.8</code></pre>
		</td>
	</tr>
	<tr>
		<td>
			REFVLAND
		</td>
		<td>
			Landing speed.
		</td>
		<td>
			Speed unit.
		</td>
		<td>
			<pre><code>REFVLAND 100kt</code></pre>
		</td>
	</tr>
	<tr>
		<td>
			REFAOALD
		</td>
		<td>
			Landing angle of attack.
		</td>
		<td>
			Degrees, followed by deg.
		</td>
		<td>
			<pre><code>REFAOALD 10deg</code></pre>
		</td>
	</tr>
	<tr>
		<td>
			REFLNRWY
		</td>
		<td>
			Runway length required for landing.
		</td>
		<td>
			Length unit.
		</td>
		<td>
			<pre><code>REFLNRWY 2000m</code></pre>
		</td>
	</tr>
	<tr>
		<td>
			REFTHRLD
		</td>
		<td>
			Landing throttle setting.
		</td>
		<td>
			Decimal, between 0 and 1.
		</td>
		<td>
			<pre><code>REFTHRLD 0.3</code></pre>
		</td>
	</tr>
	<tr class="space">
		<th colspan="4">
			Starting Conditions
		</th>
	</tr>
	<tr>
		<td>
			CTLLDGEA
		</td>
		<td>
			Whether the landing gear is on or not when starting.
		</td>
		<td>
			TRUE or FALSE.
		</td>
		<td>
			<pre><code>CTLLDGEA TRUE</code></pre>
		</td>
	</tr>
	<tr>
		<td>
			CTLBRAKE
		</td>
		<td>
			Whether the brake is on or not when starting.
		</td>
		<td>
			TRUE or FALSE.
		</td>
		<td>
			<pre><code>CTLBRAKE FALSE</code></pre>
		</td>
	</tr>
	<tr>
		<td>
			CTLSPOIL
		</td>
		<td>
			The amount the spoiler is on when starting.
		</td>
		<td>
			Decimal value, between 0 and 1.
		</td>
		<td>
			<pre><code>CTLSPOIL 0.0</code></pre>
		</td>
	</tr>
	<tr>
		<td>
			CTLABRNR
		</td>
		<td>
			Whether or no the afterburner is on when starting.
		</td>
		<td>
			TRUE or FALSE.
		</td>
		<td>
			<pre><code>CTLABRNR FALSE</code></pre>
		</td>
	</tr>
	<tr>
		<td>
			CTLTHROT
		</td>
		<td>
			The amount the throttle is on when starting.
		</td>
		<td>
			Decimal value, between 0 and 1.
		</td>
		<td>
			<pre><code>CTLTHROT 0.0</code></pre>
		</td>
	</tr>
	<tr>
		<td>
			CTLIFLAP
		</td>
		<td>
			The amount the flaps are on when starting.
		</td>
		<td>
			Decimal value, between 0 and 1.
		</td>
		<td>
			<pre><code>CTLIFLAP 0.0</code></pre>
		</td>
	</tr>
	<tr>
		<td>
			CTLINVGW
		</td>
		<td>
			The amount the wings are retracted when starting.
		</td>
		<td>
			Decimal value, between 0 and 1.
		</td>
		<td>
			<pre><code>CTLINVGW 0.0</code></pre>
		</td>
	</tr>
	<tr>
		<td>
			CTLATVGW
		</td>
		<td>
			Whether or not the wings are rectracted when starting.
		</td>
		<td>
			TRUE or FALSE.
		</td>
		<td>
			<pre><code>CTLATVGW FALSE</code></pre>
		</td>
	</tr>
	<tr>
		<td>
			POSITION
		</td>
		<td>
			How far off the ground the center of the aircraft sits.
		</td>
		<td>
			Position triplet.
		</td>
		<td>
			<pre><code>POSITION 0m 3ft 0m</code></pre>
		</td>
	</tr>
	<tr>
		<td>
			ATTITUDE
		</td>
		<td>
			Orientation of aircraft, with respect to horizon.
		</td>
		<td>
			Angle triplet, each followed by deg.
		</td>
		<td>
			<pre><code>ATTITUDE 45deg 0deg 0deg</code></pre>
		</td>
	</tr>
	<tr>
		<td>
			INITFUEL
		</td>
		<td>
			How full the fuel tank of the aircraft is when starting.
		</td>
		<td>
			Percentage, followed by %.
		</td>
		<td>
			<pre><code>INITFUEL 75%</code></pre>
		</td>
	</tr>
	<tr>
		<td>
			INITLOAD
		</td>
		<td>
			The mass of the aircrafts payload when starting.
		</td>
		<td>
			Mass unit.
		</td>
		<td>
			<pre><code>INITLOAD 0.0t</code></pre>
		</td>
	</tr>
	<tr>
		<td>
			INITSPED
		</td>
		<td>
			The speed of the aircraft when starting.
		</td>
		<td>
			Speed unit.
		</td>
		<td>
			<pre><code>INITSPED 0.0MACH</code></pre>
		</td>
	</tr>
	
	<tr class="space">
		<th colspan="4">
			Weapons
		</th>
	</tr>
	<tr>
		<td>
			MACHNGUN
		</td>
		<td>
			Machine gun position.
		</td>
		<td>
			Position triplet.
		</td>
		<td>
			<pre><code>MACHNGUN 1.8m 0.63m 1.46m</code></pre>
		</td>
	</tr>
	<tr>
		<td>
			GUNINTVL
		</td>
		<td>
			Time, in s, between gun firing.
		</td>
		<td>
			Time, as a decimal.
		</td>
		<td>
			<pre><code>GUNINTVL 0.04</code></pre>
		</td>
	</tr>
	<tr>
		<td>
			HTRADIUS
		</td>
		<td>
			The radius of the sphere used to determine whether a weapon has hit the plane. Also defines camera distance.
		</td>
		<td>
			Radius as a length unit.
		</td>
		<td>
			<pre><code>HTRADIUS 10.0m</code></pre>
		</td>
	</tr>
	<tr>
		<td>
			STRENGTH
		</td>
		<td>
			Strength of aircraft against weapons.
		</td>
		<td>
			Strength, in some fictional unit.
		</td>
		<td>
			<pre><code>STRENGTH 10</code></pre>
		</td>
	</tr>
	<tr>
		<td>
			HRDPOINT
		</td>
		<td>
			Specifies a weapon slot.
		</td>
		<td>
			Position triplet, followed by weapons that can be loaded.
		</td>
		<td>
			<pre><code>HRDPOINT  3.5m -1.1m -1.8m RKT</code></pre>
		</td>
	</tr>
	<tr>
		<td>
			MAXNMRKT
		</td>
		<td>
			Maximum number of rockets that can be loaded.
		</td>
		<td>
			Number of rockets, integer.
		</td>
		<td>
			<pre><code>MAXNMRKT 38</code></pre>
		</td>
	</tr>
	<tr>
		<td>
			LMTBYHDP
		</td>
		<td>
			Limit maximum weapons by number of slots.
		</td>
		<td>
			TRUE or FALSE.
		</td>
		<td>
			<pre><code>LMTBYHDP TRUE</code></pre>
		</td>
	</tr>
	<tr>
		<td>
			INITIGUN
		</td>
		<td>
			Initial number of rounds in gun.
		</td>
		<td>
			Number of rounds, integer.
		</td>
		<td>
			<pre><code>INITIGUN 6000</code></pre>
		</td>
	</tr>
	<tr>
		<td>
			LOADWEPN
		</td>
		<td>
			Load a number of weapons by default.
		</td>
		<td>
			Weapon and number to load as an integer.
		</td>
		<td>
			<pre><code>LOADWEPN RKT 38</code></pre>
		</td>
	</tr>
	<tr>
		<td>
			WEAPONCH
		</td>
		<td>
			Select default weapon.
		</td>
		<td>
			Name of weapon.
		</td>
		<td>
			<pre><code>WEAPONCH</code></pre>
		</td>
	</tr>
</table>

## Units

### Speed

<table>
	<tr>
		<th>Name</th>
		<th>Postfix</th>
	</tr>
	<tr>
		<td>Mach number</td>
		<td>MACH</td>
	</tr>
	<tr>
		<td>Kilometers per Hour</td>
		<td>km/h</td>
	</tr>
	<tr>
		<td>Knots</td>
		<td>kt</td>
	</tr>
	<tr>
		<td>Meters per Second</td>
		<td>m/s</td>
	</tr>
</table>

Speed is specified by an integer or decimal, followed by a postfix above. Examples of valid speeds are:
<pre><code>0.9MACH 450km/h 200kt 5m/s</code></pre> 


### Length and Height

<table>
	<tr>
		<th>Name</th>
		<th>Postfix</th>
	</tr>
	<tr>
		<td>Metres</td>
		<td>m</td>
	</tr>
	<tr>
		<td>Feet</td>
		<td>ft</td>
	</tr>
</table>

Lengths and heights are specified by an integer or decimal, followed by a postfix above. Examples include:
<pre><code>10.5m 4ft</code></pre>

### Mass

<table>
	<tr>
		<th>Name</th>
		<th>Postfix</th>
	</tr>
	<tr>
		<td>Tonnes</td>
		<td>t</td>
	</tr>
	<tr>
		<td>Kilograms</td>
		<td>kg</td>
	</tr>
</table>

Mass is specified by an integer or decimal, followed by a postfix above. Examples include:
<pre><code>5kg 0.9t</code></pre>

### Position

When sitting in the cockpit facing forward, the first value refers to your Y dimension (-ve left, +ve right), the second value refers to your Z dimension (+ve up, -ve down), and the third value refers to your X dimension (+ve forwards, -ve backwards). These are all relative to the centre of the aircraft. Each position is a length unit.

## Weapons

The following table lists weapons available in YSFlight and their shortnames:

<table>
	<tr>
		<th>Name</th>
		<th>Shortname</th>
	</tr>
	<tr>
		<td>Gun</td>
		<td>GUN</td>
	</tr>
	<tr>
		<td>Smoke</td>
		<td>SMK</td>
	</tr>
	<tr>
		<td>Rockets</td>
		<td>RKT</td>
	</tr>
	<tr>
		<td>500lb Bomb</td>
		<td>B500</td>
	</tr>
	<tr>
		<td>250lb Bomb</td>
		<td>B250</td>
	</tr>
	<tr>
		<td>Air-to-Air Missile (Short Range)</td>
		<td>AIM9</td>
	</tr>
	<tr>
		<td>Air-to-Air Missile (Medium Range)</td>
		<td>AIM120</td>
	</tr>
	<tr>
		<td>Air-to-Ground Missile</td>
		<td>AGM65</td>
	</tr>
</table>

The weapons that can be loaded (except for GUN and SMK), and the amounts, are specified by the HRDPOINT command. The following is an example from the A-10A THUNDERBOLT2:

    HRDPOINT  3.6m -0.65m -1.5m AGM65 B500 B250
    HRDPOINT -3.6m -0.65m -1.5m AGM65 B500 B250
    HRDPOINT  6.1m -0.8m -1.8m AGM65 B250

The first line specifies that the slot at that position can either take an AGM65, B500 or a B250. Only one can be loaded at a time. This allows a combination of weapons to be loaded, as well as the total limited. A valid combination for the above would be two B500 and one B250.

To specify a default number of weapons to be loaded you need to use the LOADWEPN command. A valid example for the above would be:

    LOADWEPN AGM65 2
    LOADWEPN B250 1

This would load two AGM65 and one B250.

__Note:__ This is the new system for loading weapons, the previous system isn't covered in this document.
